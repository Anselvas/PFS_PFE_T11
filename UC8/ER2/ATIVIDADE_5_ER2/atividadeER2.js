

// PRIMEIRA FORMA DE RESOLVER O EXERCÍCIO



let numeroDeAlunos = 10;

for (let contador = 0; contador <= numeroDeAlunos; contador++) 
{
    

    if(contador == 0){
        //console.log("O número atual é zero!")
        console.log(`${contador} - ZERO`) // interpolaçao
        //console.log(contador + " - ZERO") // concatenação
    }
    else if((contador % 2) == 0){
        console.log(`${contador} - PAR`)
    }

    else {
         console.log(`${contador} - IMPAR`)

    }
}



//segundo forma de resolver o exercicio

/*
let numeroDeAlunos = 10;
let contador = 0; 
while(contador <= numeroDeAlunos) 
{
    

    if(contador == 0){
        //console.log("O número atual é zero!")
        console.log(`${contador} - ZERO`) // interpolaçao
        //console.log(contador + " - ZERO") // concatenação
    }
    else if((contador % 2) == 0){
        console.log(`${contador} - PAR`)
    }

    else {
         console.log(`${contador} - IMPAR`)

    }
    contador++
}
*/


//Terceira forma de resolver o exercício
/*

let numeroDeAlunos = 10;
let contador = 0; 
 
do
{
    

    if(contador == 0){
        //console.log("O número atual é zero!")
        console.log(`${contador} - ZERO`) // interpolaçao
        //console.log(contador + " - ZERO") // concatenação
    }
    else if((contador % 2) == 0){
        console.log(`${contador} - PAR`)
    }

    else {
         console.log(`${contador} - IMPAR`)

    }
    contador++
}while(contador <= numeroDeAlunos)
*/