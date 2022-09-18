/* regras para operadores de comparação
ao comprarar duas coisa o resultado é booleano portanto true ou false
=(é ultilizado para atribuição)
== p/ comparação (verifica se é igual)
=== p/ comparação (verifica se é identico, portanto mesmo tipo de valor)
!=diferente
< menor
> maior
<= menor eou igual
>= maior ou igual
*/

/* Operadores atribuição
= atribuição
+= (x+= y) é a mesmo coisa ( x = x +y)
-= (x-= y) é  a mesma coisa que (x = x - y)
*= (x*= y) é a mesma coisa que (x = x * y)
/= (x/= y ) é a mesma coisa que (x = x / y)

*/

/* Operadores Lógicos
&& (e)
|| (ou)
! (negação)

Operador E
V && V = V
V && F = F
F && F = F
F && V = F
Posso definir que com o operador E a resposta 
apenas será VERDADEIRA se ambas as preposições 
forem VERDADEIRAS

Operador OU
V || V = V     
V || F = V
F || F = F
F || V = V
Posso definir que com o operador OU a resposta 
apenas será FALSA se ambas as preposições 
forem FALSAS

Operador !
Nega a preposição ( muda o estado lógico)
ex:
let x = false
let resultado = (!x) - (o resultado será verdadeiro)
*/


let x = true
let y = false