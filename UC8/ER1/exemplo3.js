// Sistema para um radar de velocidade

//variaveis
let velocidade;

//entrada
velocidade = 99;
velocidade = Number(prompt("Digite a velocidade!!"))
//processamento
if (velocidade >110){
    //console.log("voce foi multado!")
    alert("voce foi multado!")
}
else 
    {
        if(velocidade > 100 && velocidade < 110){
            //console.log("Voce esta sendo notificado por andar acime do limite")
            alert("Voce esta sendo notificado por andar acime do limite!")
        }
        else{
            //console.log("Voce está dentro do limite de velocidade!")
            alert("Voce está dentro do limite de velocidade!")
        }
    }
//saida