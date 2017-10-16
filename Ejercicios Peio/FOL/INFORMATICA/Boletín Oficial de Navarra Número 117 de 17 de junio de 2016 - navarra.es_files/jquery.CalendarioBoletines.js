var CalendarioBoletines = new function() {

    this.Fecha = undefined;

    jQuery(document).ready(function($) {

        var configuracion = {
            formatoFecha: 'yymmdd',
            minDate: new Date(),
            maxDate: new Date(),
            urlLimitesCalendario: '/appsext/BON/CalendarioBoletines/LimitesCalendario.ashx',
            urlBoletinesMes: '/appsext/BON/CalendarioBoletines/BoletinesMes.ashx',
            ruta: (document.location.pathname.match(/home_[a-z]{2}/i) || '')
        };

        function mostrarCalendario() {
            $('#tercerNivel').after(
                $('<div id="calendarioBoletines"><!-- Calendario de boletines --></div>')
                .datepicker({

                    dateFormat: configuracion.formatoFecha,
                    minDate: configuracion.minDate,
                    maxDate: configuracion.maxDate,
                    //defaultDate: configuracion.maxDate,
                    defaultDate: CalendarioBoletines.Fecha,

                    onChangeMonthYear: function(anno, mes, calendario) {

                        var _boletines;

                        $.ajax({
                            type: 'GET',
                            url: configuracion.urlBoletinesMes,
                            data: { ruta: configuracion.ruta, anno: anno, mes: mes },
                            dataType: 'json',
                            async: false,
                            success: function(boletines) {
                                _boletines = boletines;
                            }
                        });

                        this.boletines = _boletines;
                    },

                    beforeShowDay: function(fecha) {

                        var textoFecha = $.datepicker.formatDate(configuracion.formatoFecha, fecha);

                        var boletin = this.boletines[textoFecha];

                        if (boletin != null) {
                            var titulo = '';
                            var separador = '';
                            var clase = '';

                            for (var i = 0; i < boletin.length; i++) {
                                titulo = titulo + separador + boletin[i].Titulo;
                                separador = ', ';
                                if (boletin[i].Extraordinario) {
                                    clase = 'extraordinario';
                                }
                            }

                            return [true, clase, titulo];
                        } else {
                            return [false];
                        }
                    },

                    onSelect: function(textoFecha, calendario) {
                        var boletin = this.boletines[textoFecha];

                        if (boletin.length > 1) {
                            var contenido = $('<div></div>').addClass('ui-datepicker-header');

                            for (var i = 0; i < boletin.length; i++) {
                                contenido.append(
                                    '<a href="' + boletin[i].Url + '">' +
                                    boletin[i].Titulo +
                                    '</a>' +
                                    '<br />');
                            }

                            var popup = $('<div><!-- Popup --></div>')
                                .addClass('ui-datepicker')
                                .addClass('ui-widget ui-widget-content ui-corner-all')
                                .css('font-size', '.72em')
                                .css('display', 'block')
                                .css('position', 'absolute')
                                .append(contenido)
                                .mouseleave(function(e) {
                                    $(this).remove();
                                });

                            $('body').append(popup);

                            popup
                                .css('left', this.pageX - (popup.outerWidth() / 2))
                                .css('top', this.pageY - (popup.outerHeight() / 2));

                            this.popup = popup;
                        }
                        else if (boletin.length == 1) {
                            window.location = boletin[0].Url;
                        }
                        //$(this).datepicker('setDate', calendario.settings.defaultDate);
                    }
                })
                .mouseup(function(e) {
                    this.pageX = e.pageX;
                    this.pageY = e.pageY;
                })
            );
        }

        $.ajax({
            type: 'GET',
            url: configuracion.urlLimitesCalendario,
            data: { ruta: configuracion.ruta },
            dataType: 'json',
            async: true,
            success: function(limites) {
                configuracion.minDate =
                    $.datepicker.parseDate(configuracion.formatoFecha, limites.FechaPrimerBoletin);
                configuracion.maxDate =
                    $.datepicker.parseDate(configuracion.formatoFecha, limites.FechaUltimoBoletin);
                if (CalendarioBoletines.Fecha === undefined) {
                    CalendarioBoletines.Fecha = configuracion.maxDate;
                }
            },
            complete: function(xmlHttpRequest) {
                mostrarCalendario();
            }
        });
    });
};
