using Domain.Model;
using WindowsForms.APIServices;

namespace WindowsForms;

public partial class CursosDetalle : Form
{
    private Curso curso;

    public Curso Curso
    {
        get { return curso; }
        set
        {
            curso = value;
            this.SetCurso();
        }
    }
    public CursosDetalle()
    {
        InitializeComponent();
    }
    private async void SetCurso()
    {

        this.txtid_id_curso.Text=this.Curso.id_curso.ToString();
        this.cmbid_materia.DataSource = await MateriaApiClient.GetAllAsync();
        this.cmbid_materia.DisplayMember = "desc_materia";
        this.cmbid_materia.ValueMember = "id_materia";
        this.cmbid_materia.SelectedValue = this.Curso.id_materia;

        this.cmbid_comision.DataSource = await ComisionApiClient.GetAllAsync();
        this.cmbid_comision.DisplayMember = "desc_comision";
        this.cmbid_comision.ValueMember = "id_comision";
        this.cmbid_comision.SelectedValue = this.Curso.id_materia;

        this.txtanio_calendario.Text = this.Curso.anio_calendario.ToString();
        this.txtcupo.Text = this.Curso.cupo.ToString();

    }
    private async void Aceptar_Click(object sender, EventArgs e)
    {
        this.Curso.id_materia =  (int)this.cmbid_materia.SelectedValue;
        this.Curso.id_comision =  (int)this.cmbid_comision.SelectedValue;
        this.Curso.anio_calendario = int.Parse(this.txtanio_calendario.Text);
        this.Curso.cupo = int.Parse(this.txtcupo.Text);

        if (txtid_id_curso.Text == "0" || txtid_id_curso.Text.Length == 0)
        {
            await CursoApiClient.AddAsync(Curso);
        }
        else
        {
            await CursoApiClient.UpdateAsync(Curso);
        }

        this.Close();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
