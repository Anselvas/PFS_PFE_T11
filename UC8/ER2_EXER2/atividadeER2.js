

/*let numeroDeAlunos = 10;

for(let contador = 0; contador<= numeroDeAlunos; contador++){
    if(contador == 0){
        console.log(`${contador} - ZERO `) // INTERPOLAÇÃO  
    }
    else if((contador % 2) == 0){
        console.log(`${contador} - PAR`)
    
    }
    else{
        console.log(`${contador} - IMPAR`)
    }

}

*/

let numeroDeAlunos = 10;
let contador = 0
while (contador<= numeroDeAlunos)
{


    if(contador == 0){
        console.log(`${contador} - ZERO `) // INTERPOLAÇÃO  
    }
    else if((contador % 2) == 0){
        console.log(`${contador} - PAR`)
    
    }
    else{
        console.log(`${contador} - IMPAR`)
    }
    contador++
}