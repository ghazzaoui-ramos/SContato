// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

/*let table = new DataTable('#table-contatos', {
    "ordering": true, // "ordenando": verdadeiro
    "paging": true,   // "paginação": verdadeiro
    "searching": true, // "procurando": verdadeiro
    "language": {
        "emptyTable": "Nenhum registro encontrado na tabela",
        "info": "Mostrar _START_ até _END_ de _TOTAL_ registros",
        "infoEmpty": "Mostrar 0 até 0 de 0 Registros",
        "infoFiltered": "(Filtrar _MAX_ total de registros)",
        "infoThousands": ".", // "sInfoMilhares": "."
        "lengthMenu": "Mostrar _MENU_ registros por página",
        "loadingRecords": "Carregando...",
        "processing": "Processando...",
        "zeroRecords": "Nenhum registro encontrado",
        "search": "Pesquisar",
        "paginate": {
            "next": ">",
            "previous": "<",
            "first": "<<",
            "last": ">>"
        },
        "aria": {
            "sortAscending": ": Ordenar colunas de forma ascendente",
            "sortDescending": ": Ordenar colunas de forma descendente"
        }
    }
});*/

$(document).ready(function () {
    getDatatable('#table-contatos');
    getDatatable('#table-usuarios');
})

function getDatatable(id) {
    $(id).DataTable({
        "ordering": true,
        "paging": true,  
        "searching": true, 
        "language": {
            "emptyTable": "Nenhum registro encontrado na tabela",
            "info": "Mostrar _START_ até _END_ de _TOTAL_ registros",
            "infoEmpty": "Mostrar 0 até 0 de 0 Registros",
            "infoFiltered": "(Filtrar _MAX_ total de registros)",
            "infoThousands": ".", 
            "lengthMenu": "Mostrar _MENU_ registros por página",
            "loadingRecords": "Carregando...",
            "processing": "Processando...",
            "zeroRecords": "Nenhum registro encontrado",
            "search": "Pesquisar",
            "paginate": {
                "next": ">",
                "previous": "<",
                "first": "<<",
                "last": ">>"
            },
            "aria": {
                "sortAscending": ": Ordenar colunas de forma ascendente",
                "sortDescending": ": Ordenar colunas de forma descendente"
            }
        }
    });
}

//let table = new DataTable('#table-contatos');

$('.close-alert').click(function () {
    $('.alert').hide('hide');
});

