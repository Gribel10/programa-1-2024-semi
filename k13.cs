﻿
using Microsoft.Win32;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Xml.Linq;

using System;

< form id = "frmDocente" data - iddocente = "0" data - accion = "nuevo" >
    < div class= "card text-bg-dark mb-3" style = "min-width:700px;" >
        < div class= "card-header" >
            < div class= "d-flex" >
                Registro de Docentes
                <div class= "ms-auto" >
                    < button type = "button" data - form = "docente" class= "btn-close btn-close-white" ></ button >
                </ div >
            </ div >
        </ div >
        < div class= "card-body" >
            < div class= "row p-1" >
                < div class= "col-3 col-md-2" > CODIGO:</ div >
                < div class= "col-9 col-md-4" >
                    < input type = "text" class= "form-control" id = "txtCodigoDocente" name = "txtCodigoDocente" required >
                </ div >
            </ div >
            < div class= "row p-1" >
                < div class= "col-3 col-md-2" > NOMBRE:</ div >
                < div class= "col-9 col-md-8" >
                    < input type = "text" class= "form-control" id = "txtNombreDocente" name = "txtNombreDocente" required >
                </ div >
            </ div >
            < div class= "row p-1" >
                < div class= "col-3 col-md-2" > DIRECCION:</ div >
                < div class= "col-9 col-md-10" >
                    < input type = "text" class= "form-control" id = "txtDireccionDocente" name = "txtDireccionDocente" required >
                </ div >
            </ div >
            < div class= "row p-1" >
                < div class= "col-3 col-md-2" > TELEFONO:</ div >
                < div class= "col-9 col-md-4" >
                    < input type = "text" class= "form-control" id = "txtTelefonoDocente" name = "txtTelefonoDocente" required >
                </ div >
            </ div >
            < div class= "row p-1" >
                < div class= "col-3 col-md-2" > FOTO:</ div >
                < div class= "col-9 col-md-4" >
                    < div class= "input-group mb-3" >
                        < label class= "input-group-text" for= "imgFotodocente" > Upload </ label >
                        < input type = "file" class= "form-control" id = "imgFotodocente"
                               accept = "image/*" onchange = "selecionarImg(this)" >
                    </ div >
                </ div >
                < div class= "col-3 col-md-4" >
                    < img class= "img-thumbnail rounded" id = "imgPreVisualizacionFotoDocente" />
                </ div >
            </ div >
            < div class= "row p-1" >
                < div class= "col-12" >
                    < input type = "submit" class= "btn btn-primary" value = "Guardar" >
                    < input type = "reset" class= "btn btn-warning" value = "Nuevo" >
                    < button type = "button" class= "btn btn-success" onclick = "abrirVentanas('busqueda_docente')" > Buscar </ button >
                </ div >
            </ div >
        </ div >
    </ div >
</ form >
< script >
    var miArchivo;
function selecionarImg(file)
{
    let archivo = file.files[0];
    const reader = new FileReader();
    reader.onload = event => {
        miArchivo = event.target.result;
            $("#imgPreVisualizacionFotoDocente").attr("src", miArchivo);
    };
    reader.readAsDataURL(archivo);
}
frmDocente.addEventListener('submit', e => {
    e.preventDefault();
    guardarDocentes();
});
frmDocente.addEventListener('reset', e => {
    e.preventDefault();
    limpiarDatosDocentes();
});
async function guardarDocentes()
{
    let datos = {
                codigo: txtCodigoDocente.value,
                nombre: txtNombreDocente.value,
                direccion: txtDireccionDocente.value,
                telefono: txtTelefonoDocente.value,
            },
                method = "POST",
                url = "https://localhost:7041/api/Docentes";
if (frmDocente.dataset.accion == "modificar")
{
    url = `https://localhost:7041/api/Docentes/${frmDocente.dataset.iddocente}`;
    datos.idDocente = frmDocente.dataset.iddocente;
    method = "PUT";
}
const respuesta = await fetch(url, {

    method,
    headers: {

        "Content-Type": "application/json"
                },
                body: JSON.stringify(datos)
            }), docente = await respuesta.json();
if (docente && docente?.idDocente > 0)
{
    alertify.success("Docente guardado con exito.");
    listarDocentes();
    limpiarDatosDocentes();
}
else
{
    alertify.error(`Erro al intentar guardar el docente: ${ docente}`);
    conosle.log(docente);
}
        }
        function modificarDocente(docente)
{
    frmDocente.dataset.iddocente = docente.idDocente;
    frmDocente.dataset.accion = "modificar";
    txtCodigoDocente.value = docente.codigo;
    txtNombreDocente.value = docente.nombre;
    txtDireccionDocente.value = docente.direccion;
    txtTelefonoDocente.value = docente.telefono;
}
function limpiarDatosDocentes()
{
    frmDocente.dataset.iddocente = 0;
    frmDocente.dataset.accion = "nuevo";
    txtCodigoDocente.value = "";
    txtNombreDocente.value = "";
    txtDireccionDocente.value = "";
    txtTelefonoDocente.value = "";
}
</ script >