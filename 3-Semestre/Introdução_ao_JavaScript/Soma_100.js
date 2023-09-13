numero = 0;

for (let i = 1; i <= 100; i++) {
    if (i != 100){
    document.write(i + " + ")
    }
    else {
    document.write(i);
    }
}

for (let i = 1; i <= 100; i++) {
    numero = numero + i;
    if (i == 100) {
    document.write("<br>" + "A soma é de: " + numero);
    }
}