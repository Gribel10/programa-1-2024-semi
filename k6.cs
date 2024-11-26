  }
        private void estadoControles(Boolean estado)
{
    grbDatosAlumno.Enabled = estado;
    grbNavegacionAlumno.Enabled = !estado;
    btnEliminarAlumno.Enabled = !estado;
    btnBuscarAlumno.Enabled = !estado;
}
private void btnNuevoAlumno_Click(object sender, EventArgs e)
{
    if (btnNuevoAlumno.Text == "Nuevo")
    {
        btnNuevoAlumno.Text = "Guardar";
        btnModificarAlumno.Text = "Cancelar";
        estadoControles(true);
    }
    else
    {//Guardar
        btnNuevoAlumno.Text = "Nuevo";
        btnModificarAlumno.Text = "Modificar";
        estadoControles(false);
    }
}
private void btnModificarAlumno_Click(object sender, EventArgs e)
{
    if (btnModificarAlumno.Text == "Modificar")
    {
        btnNuevoAlumno.Text = "Guardar";
        btnModificarAlumno.Text = "Cancelar";
        estadoControles(true);
    }
    else
    {//Cancelar
        btnNuevoAlumno.Text = "Nuevo";
        btnModificarAlumno.Text = "Modificar";
        estadoControles(false);
    }
}
    }
}