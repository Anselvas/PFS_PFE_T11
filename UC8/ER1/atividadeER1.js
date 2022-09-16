let listaDepecas = []
listaDepecas.push('Disco de freio')
listaDepecas.push('Motor')
listaDepecas.push('Amortecedor')

//listaDepecas[] = "Pastolha"  // alternar item da lista

if (listaDepecas.length < 10){
    console.log("É possível cadastrar mais peças!")
}
else{
    console.log('Não tem mais espaço na caixa!')
}
let peso = 200
if (peso < 100){
    console.log('A peça deve pesar no mínimo 100g')
}
else{
    console.log('A peça possui o peso adequado!')
}

let nomePeca = 'Freio'

if(nomePeca.length > 3){
    console.log('O nome da peça está adequado para cadastro!')
}
else if (nomePeca.length == 0){
    console.log("O nome da peça não pode ser vazio.")
}
else{
    console.log(" O nome da peça deve ter mais de 3 caracteres, digite o nome adequado!")
}