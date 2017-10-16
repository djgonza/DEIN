new function() {
    // Cargamos el valor de las parámetros especificos para las búsquedas
    var input_xt_mtcl = document.getElementById("xt_mtcl");
    var input_xt_npg = document.getElementById("xt_npg");

    if (input_xt_mtcl || input_xt_npg) {
        var xt_mtcl;
        var xt_npg;

        if (input_xt_mtcl) {
            xt_mtcl = escape(input_xt_mtcl.value); //Palabra de búsqueda
        } else {
            xt_mtcl = "";
        }

        if (input_xt_npg) {
            xt_npg = escape(input_xt_npg.value); //número de páginas de resultados. “0” cuando no haya resultados.
        } else {
            xt_npg = "";
        }

        //do not modify below
        if (window.xtparam != null) { window.xtparam += "&mc=" + xt_mtcl + "&np=" + xt_npg; }
        else { window.xtparam = "&mc=" + xt_mtcl + "&np=" + xt_npg; };
    }

    // Modificamos los enlaces a los recursos descargables para que quede constancia de las descargas de los mismos
    var filtroDescargas;
    var filtroUrlDescarga = new RegExp('/NR/([^/]+/)+', 'i');

    function obtenerNombreEnlace(enlace) {
        var nombre = '';
        var finCapitulo = xtpage.lastIndexOf('::');
        if (finCapitulo >= 0) {
            finCapitulo += 2;
            nombre = nombre + xtpage.substring(0, finCapitulo);
        }
        nombre = nombre + enlace.href.replace(filtroUrlDescarga, '/NR/.../');

        return nombre;
    }

    function generarRedireccionDescarga(enlace) {
        enlace.href =
            xtsd + '.xiti.com/go.click' +
            '?xts=' + encodeURIComponent(xtsite) +
            '&s2=' + encodeURIComponent(xtn2) +
            '&p=' + encodeURIComponent(obtenerNombreEnlace(enlace)) +
            '&click=T' +
            '&type=click' +
            '&url=' + encodeURIComponent(enlace.href);
    }

    top.tratarEnlaces = function(documento) {
        for (var i in documento.links) {
            var enlace = documento.links[i];
            if (filtroDescargas.test(enlace) == true) {
                generarRedireccionDescarga(enlace);
            }
        }
    }

    window.generarEstadisticas = function(parametros) {
        window.host = parametros.host;
        window.url = parametros.url;
        window.xtnv = parametros.documentoBase; // parent.document or top.document or document
        window.xtsd = parametros.servidorEstadisticas;
        window.xtsite = parametros.sitio;
        window.xtn2 = parametros.nivel; // sitio de nivel 2
        window.xtpage = '' + parametros.capitulo + parametros.pagina; // nombre de la página sin espacios (uso de :: para la creacion de cap)
        window.xtdi = parametros.gradoImplicacion; // grado de implicación
        window.xt1 = parametros.dominioCookie; // dominio de la cookie
        window.xt_multc = '&x1=' + parametros.idioma + '&x2=' + parametros.departamento; // indicadores personalizados
        window.xt_an = ''; // ID de usuario
        window.xt_ac = ''; // ID de categoria
        filtroDescargas = new RegExp(parametros.descargas, 'i')
        // no modificar
        if (window.xtparam != null) {
            window.xtparam += window.xt_multc + "&ac=" + window.xt_ac + "&an=" + window.xt_an;
        } else {
            window.xtparam = window.xt_multc + "&ac=" + window.xt_ac + "&an=" + window.xt_an;
        };

        top.tratarEnlaces(document);
    };

    window.generarClickZone = function() {
        if (window.xtclzone && window.xtNodesload && window.xtclzone > 0) {
            window.xtNodesload();
        }
    };
};
