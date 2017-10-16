function ventanaNueva(className,features,message){
 var as = document.getElementsByTagName('a');
 
 var r=new RegExp("(^| )"+className+"($| )");
 
 for(var i=0;i<as.length;i++){
      var a = as[i];
      if(r.test(a.className)){
			a.title= a.title + " " + message;
			a.onclick = function(){
                window.open(this.href, 'nuevaVentana', features);
                return false;
		    }        
      }
    }
}

function abrirPopup(message){
    var className = '';
	var features ='';
    className = 'nuevaVentana';
	features='toolbar=yes,location=yes,directories=yes,status=yes,menubar=yes,scrollbars=yes,resizable=yes,copyhistory=no';
	ventanaNueva(className,features, message);
}