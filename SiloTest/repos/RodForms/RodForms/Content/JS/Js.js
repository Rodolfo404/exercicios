var doceLista = [];

function save() {
    let id = parseInt(document.getElementById("id").value);
    let nome = document.getElementById("nome").value;
    let tipo = document.getElementById("tipo").value;
    let gramagem = parseInt(document.getElementById("gra").value);
    lista = { "id": id, "nome": nome, "tipo": tipo, "gramagem": gramagem };
    doceLista.push(lista);
    localStorage.setItem("doceLista", JSON.stringify(doceLista));

}



function convert() {
    let cadastroJson = localStorage.getItem("doceLista");
    if (cadastroJson != null) {
        doceLista = JSON.parse(cadastroJson);
    }
}

function carregarTabela() {
    let tabela = document.getElementById("listaD");
    let corpo = tabela.getElementsByTagName("tbody")[0];
    corpo.innerHTML = "";
    doceLista.forEach(d => {
        corpo.innerHTML += `<tr><td>${d.id}</td><td>${d["nome"]}</td><td>${d["tipo"]}</td><td>${d["gramagem"]}</td></tr>`;
    });
}


window.onload = function () {
    convert();
    carregarTabela();
}
