let listaDePecas = ['Filtro de Ar','Roda', 'Pneu','Radio','Volante','Espelho','Lampada de freio']

listaDePecas.push('Disco de freio')
listaDePecas.push('Motor')
listaDePecas.push('Amortecedor')

//listaDePecas[2] = 'Pastilha' //alterar lista de peças pelo indice

if( listaDePecas.length < 10){
    console.log('É possível cadastrar mais peças!!')
}
else{
    console.log("Não tem mais espaço na caixa!!")
}

let peso = 102
if(peso < 100){
    console.log("A peça deve pesar no mínimo 100g")
}

else{
    console.log("A peça possui peso adequado!!")
}

let nomePeca = 'freio'

if (nomePeca.length > 3){
    console.log("O nome da peça esta adequado para cadastro!!")
}

else if(nomePeca.length == 3){
    console.log("O nome da peça não pode ser vazio.")
}

else{
    console.log("O nome da peça deve ter mais de 3 caracteres, digite o nome adequado")
}