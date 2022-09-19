// cadastro de eventos
//variaveis

let listaDeParticipantes = ["Paula", "Pedro","Marcia"]

let datahoje = new Date();
let dataUser = new Date("09/19/2022")

if(dataUser<datahoje)
{
    alert("Data invalida!");
}
else{

let idade = Number(prompt("Digite a idade!"))

if (idade<18){
    //console.log("voce foi multado!")
    alert("Idade não permitida!");
}
else
{
    let contador = 0;

    if (listaDeParticipantes.length<100){
        listaDeParticipantes.push("Thomas");
        alert("Permitir cadastro!")
    }
    else{
        alert("Limite excedido!");
    }

    while(contador < listaDeParticipantes.length ){
        alert("Participante "+(contador+1)+" de "+listaDeParticipantes.length+": "+listaDeParticipantes[contador] );
        contador++;
    }

}
}