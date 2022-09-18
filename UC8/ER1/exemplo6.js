
let nomePeca = 'Freio'

switch (nomePeca){
    case 0:
        console.log ('O nome da peça não pode ser vazio!')
        break;
    case 1:
    case 2:
    case 3:
        console.log('O nome da peça deve ter mais de 3 caracteres!')
        break;
    default:
        console.log('O nome da peça esta adequado para o cadastro!')
        break;
}




/*
if(nomePeca.length > 3){
    console.log('O nome da peça está adequado para cadastro!')
}
else if (nomePeca.length == 0){
    console.log("O nome da peça não pode ser vazio.")
}
else{
    console.log(" O nome da peça deve ter mais de 3 caracteres, digite o nome adequado!")
}
*/