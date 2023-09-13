let num1 = Number(prompt("Digite o primeiro número: "));
let num2 = Number(prompt("Digite o segundo número: "));
let num3 = Number(prompt("Digite o terceiro número: "));

if (num1 > num2 && num1 > num3) {
    alert("O maior numero é: " + num1);
}
if (num2 > num1 && num2 > num3) {
    alert("O maior numero é: " + num2);
}
if (num3 > num1 && num3 > num2) {
    alert("O maior numero é: " + num3);
}