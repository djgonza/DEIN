        
        var estilo = readCookie("style2");
        var title = estilo ? estilo : getPreferredStyleSheet();
        setActiveStyleSheet(title);

        function setActiveStyleSheet(title) 
        {
            var i, a, main;
            var listo = 0;
            
            for(i=0; (a = document.getElementsByTagName("link")[i]); i++) 
            {
                if(a.getAttribute("rel") && a.getAttribute("rel").indexOf("style") != -1 && a.getAttribute("title")) 
                {
                    a.disabled = true;
                    if(a.getAttribute("title") == title)
                    {
                        listo = 1;
                        a.disabled = false;
                        createCookie("style2", title, 365);
                    }
                }
            }
            if((listo == 0) && (title != "print")) 
            {
	            document.getElementsByTagName("link")[0].disabled = false;
            }
        }

        function getActiveStyleSheet() 
        {
            var i, a;
            for(i=0; (a = document.getElementsByTagName("link")[i]); i++) 
            {
                if(a.getAttribute("rel").indexOf("style") != -1 && a.getAttribute("title") && !a.disabled)
                {			        
			        return a.getAttribute("title");
		        }
            }
            return null;
        }

        function getPreferredStyleSheet() 
        {
            var i, a;
            for(i=0; (a = document.getElementsByTagName("link")[i]); i++) {
                if(a.getAttribute("rel").indexOf("style") != -1
                   && a.getAttribute("rel").indexOf("alt") == -1
                   && a.getAttribute("title")
                ) return a.getAttribute("title");
            }
            return null;
        }


        function estiloMenos() {
            estiloActual = getActiveStyleSheet();            
            if (estiloActual != null)
            {
                numEstiloActual = (estiloActual.substring(5,6) *1);
                if (numEstiloActual>0){
                    numEstilo = numEstiloActual - 1;
                    nombreEstilo ="style" + numEstilo;        
                    setActiveStyleSheet(nombreEstilo, 1);
                }   
            }           
            
        }

        function estiloMas() 
        {
            estiloActual = getActiveStyleSheet();            
            if (estiloActual != null)
            {
                numEstiloActual = (estiloActual.substring(5,6) * 1);
                if (numEstiloActual<3){
                    numEstilo = numEstiloActual + 1;
                    nombreEstilo ="style" + numEstilo;        
                    setActiveStyleSheet(nombreEstilo, 1);
                }
            }           
                       
        }
        
        function estiloImprimir()
        {             
            setActiveStyleSheet("print", 1);
            readCookie("style2");
            print();
            setActiveStyleSheet("style1");   
        }
        
        
        function createCookie(name,value,days) 
        {
            if (days) 
            {
                var date = new Date();
                date.setTime(date.getTime()+(days*24*60*60*1000));
                var expires = "; expires="+date.toGMTString();
            }
            else expires = "";
            document.cookie = name+"="+value+expires+"; path=/";
        }
        
                
        function readCookie(name) 
        {
            var nameEQ = name + "=";
            var ca = document.cookie.split(';');
            for(var i=0;i < ca.length;i++) 
            {
                var c = ca[i];
                while (c.charAt(0)==' ') c = c.substring(1,c.length);
                if (c.indexOf(nameEQ) == 0) return c.substring(nameEQ.length,c.length);
            }   
        return null;
        }
        
