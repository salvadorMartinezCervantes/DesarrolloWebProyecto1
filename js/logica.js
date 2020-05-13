

 

function validar() {
    console.log("hjvdghsjgdj");
    usuarioBase=localStorage.getItem("usuarioBase");
    paswordBase=localStorage.getItem("paswordBase" );

    
    var inputusuario, inputpasword;
    inputusuario = document.getElementById("usr").value;
    inputpasword = document.getElementById("pw").value;
    

    console.log("usuarioBase: ",usuarioBase);
    console.log("paswordBase: ",paswordBase);
    
    console.log("usuarioInput: ",inputusuario);
    console.log("paswordInput: ",inputpasword);

    console.log("hjvdghsjgdj");
    if( inputusuario!==usuarioBase || inputpasword!==paswordBase){
        alert("datos incorrectos");
        return false;
    }else{
        return true;
    }
 
}




function registar() {

    var usuarioBase="";
    var paswordBase="";

    usuarioBase = document.getElementById("usuario").value;
    paswordBase = document.getElementById("pasword").value;
    console.log(paswordBase);
    let nombre ="hjjbhgbhj";

localStorage.setItem("usuarioBase", usuarioBase);
localStorage.setItem("paswordBase", paswordBase );
   return true;

}



/*
function validar() {
    var usur, pws;
    usur = document.getElementById("usr").value;
    pws = document.getElementById("pw").value;
    
    if( usur!=="polongipunk" || pws!=="root"){
        alert("datos incorrectos");
        return false;
    }else{
        return true;
    }
}


guardar();

function guardar() {

    var nombre ="hjjbhgbhj";

localStorage.setItem("nombressse",nombre);

}
*/
      