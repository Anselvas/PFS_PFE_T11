function cadastrarNewsletter(){
    //alert("CadastrarNewsletters")
        //let numero1=5
        //let numero2=10
        //let resultado= numero1 + numero2
        //console.log(resultado)
    let email = document.getElementById("campo-email").value
    alert (email)
}

function mostrarMenu($event) {
    //identificar elemento do menu
    let menu = document.getElementById("menu")

    //if(menu.style.display == "none"){
    if(getComputedStyle(menu).display == "none"){
        menu.style.display = "flex"
    }
    else{
        menu.style.display = "none"
    }
        event.preventDefault();

    
  
}
