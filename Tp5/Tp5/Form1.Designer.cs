namespace Tp5
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_actual = new System.Windows.Forms.GroupBox();
            this.txt_evento = new System.Windows.Forms.TextBox();
            this.txt_hora = new System.Windows.Forms.TextBox();
            this.txt_dia = new System.Windows.Forms.TextBox();
            this.lbl_evento = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.lbl_dia = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.col_dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proxima_llegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_elige_peluquero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fin_atencion_aprendiz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.con_fin_atencion_veteranoA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fin_atencion_veteranoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estadoAprend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_colaApren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prcol_cant_atendidos_aprendiz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ganancia_aprendiz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estado_veteranoA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_colaVereranoA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cant_clien_veteranoA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_darsena_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estado_veteranoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_colaVeteranoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cant_cliVeteranoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_gananciaVeteranoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permanencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_simular = new System.Windows.Forms.Button();
            this.gb_cantidades = new System.Windows.Forms.GroupBox();
            this.txt_hasta = new System.Windows.Forms.TextBox();
            this.txt_desde = new System.Windows.Forms.TextBox();
            this.txt_dias = new System.Windows.Forms.TextBox();
            this.lbl_dias = new System.Windows.Forms.Label();
            this.lbl_hasta = new System.Windows.Forms.Label();
            this.lbl_desde = new System.Windows.Forms.Label();
            this.gb_recalibracion = new System.Windows.Forms.GroupBox();
            this.txt_llegadaCli_hasta = new System.Windows.Forms.TextBox();
            this.lbl_recalibracion_varianza = new System.Windows.Forms.Label();
            this.txt_llegadaCli_desde = new System.Windows.Forms.TextBox();
            this.lbl_recalibracion_media = new System.Windows.Forms.Label();
            this.gb_darsenas = new System.Windows.Forms.GroupBox();
            this.txt_vetB_hasta = new System.Windows.Forms.TextBox();
            this.lbl_darsenas_b = new System.Windows.Forms.Label();
            this.txt_vetB_desde = new System.Windows.Forms.TextBox();
            this.lbl_darsenas_a = new System.Windows.Forms.Label();
            this.gb_balanza = new System.Windows.Forms.GroupBox();
            this.txt_vetA_hasta = new System.Windows.Forms.TextBox();
            this.lbl_balanza_b = new System.Windows.Forms.Label();
            this.txt_vetA_desde = new System.Windows.Forms.TextBox();
            this.lbl_balanza_a = new System.Windows.Forms.Label();
            this.gb_recepcion = new System.Windows.Forms.GroupBox();
            this.txt_aprendiz_hasta = new System.Windows.Forms.TextBox();
            this.lbl_recepcion_b = new System.Windows.Forms.Label();
            this.txt_aprendiz_desde = new System.Windows.Forms.TextBox();
            this.lbl_recepcion_a = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_probVetB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_probVetA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_probAprendiz = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bnt_simular = new System.Windows.Forms.Button();
            this.gb_actual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.gb_cantidades.SuspendLayout();
            this.gb_recalibracion.SuspendLayout();
            this.gb_darsenas.SuspendLayout();
            this.gb_balanza.SuspendLayout();
            this.gb_recepcion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_actual
            // 
            this.gb_actual.Controls.Add(this.txt_evento);
            this.gb_actual.Controls.Add(this.txt_hora);
            this.gb_actual.Controls.Add(this.txt_dia);
            this.gb_actual.Controls.Add(this.lbl_evento);
            this.gb_actual.Controls.Add(this.lbl_hora);
            this.gb_actual.Controls.Add(this.lbl_dia);
            this.gb_actual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_actual.Location = new System.Drawing.Point(1378, 22);
            this.gb_actual.Margin = new System.Windows.Forms.Padding(4);
            this.gb_actual.Name = "gb_actual";
            this.gb_actual.Padding = new System.Windows.Forms.Padding(4);
            this.gb_actual.Size = new System.Drawing.Size(316, 105);
            this.gb_actual.TabIndex = 25;
            this.gb_actual.TabStop = false;
            this.gb_actual.Text = "Simulación actual:";
            // 
            // txt_evento
            // 
            this.txt_evento.CausesValidation = false;
            this.txt_evento.Location = new System.Drawing.Point(189, 57);
            this.txt_evento.Margin = new System.Windows.Forms.Padding(4);
            this.txt_evento.Name = "txt_evento";
            this.txt_evento.ReadOnly = true;
            this.txt_evento.Size = new System.Drawing.Size(117, 24);
            this.txt_evento.TabIndex = 5;
            // 
            // txt_hora
            // 
            this.txt_hora.CausesValidation = false;
            this.txt_hora.Location = new System.Drawing.Point(69, 57);
            this.txt_hora.Margin = new System.Windows.Forms.Padding(4);
            this.txt_hora.Name = "txt_hora";
            this.txt_hora.ReadOnly = true;
            this.txt_hora.Size = new System.Drawing.Size(111, 24);
            this.txt_hora.TabIndex = 4;
            // 
            // txt_dia
            // 
            this.txt_dia.CausesValidation = false;
            this.txt_dia.Location = new System.Drawing.Point(12, 57);
            this.txt_dia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dia.Name = "txt_dia";
            this.txt_dia.ReadOnly = true;
            this.txt_dia.Size = new System.Drawing.Size(48, 24);
            this.txt_dia.TabIndex = 3;
            // 
            // lbl_evento
            // 
            this.lbl_evento.AutoSize = true;
            this.lbl_evento.Location = new System.Drawing.Point(185, 37);
            this.lbl_evento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_evento.Name = "lbl_evento";
            this.lbl_evento.Size = new System.Drawing.Size(58, 18);
            this.lbl_evento.TabIndex = 2;
            this.lbl_evento.Text = "Evento:";
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Location = new System.Drawing.Point(65, 37);
            this.lbl_hora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(45, 18);
            this.lbl_hora.TabIndex = 1;
            this.lbl_hora.Text = "Hora:";
            // 
            // lbl_dia
            // 
            this.lbl_dia.AutoSize = true;
            this.lbl_dia.Location = new System.Drawing.Point(8, 37);
            this.lbl_dia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dia.Name = "lbl_dia";
            this.lbl_dia.Size = new System.Drawing.Size(34, 18);
            this.lbl_dia.TabIndex = 0;
            this.lbl_dia.Text = "Día:";
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.CausesValidation = false;
            this.dataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.ColumnHeadersHeight = 41;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_dia,
            this.reloj,
            this.evento,
            this.proxima_llegada,
            this.col_elige_peluquero,
            this.col_fin_atencion_aprendiz,
            this.con_fin_atencion_veteranoA,
            this.col_fin_atencion_veteranoB,
            this.col_estadoAprend,
            this.col_colaApren,
            this.prcol_cant_atendidos_aprendiz,
            this.col_ganancia_aprendiz,
            this.col_estado_veteranoA,
            this.col_colaVereranoA,
            this.col_cant_clien_veteranoA,
            this.estado_darsena_2,
            this.col_estado_veteranoB,
            this.col_colaVeteranoB,
            this.col_cant_cliVeteranoB,
            this.col_gananciaVeteranoB,
            this.permanencia});
            this.dataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dataGrid.Location = new System.Drawing.Point(13, 171);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGrid.RowTemplate.ReadOnly = true;
            this.dataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.ShowCellErrors = false;
            this.dataGrid.ShowCellToolTips = false;
            this.dataGrid.ShowEditingIcon = false;
            this.dataGrid.ShowRowErrors = false;
            this.dataGrid.Size = new System.Drawing.Size(1258, 497);
            this.dataGrid.TabIndex = 23;
            // 
            // col_dia
            // 
            this.col_dia.HeaderText = "Dia";
            this.col_dia.Name = "col_dia";
            this.col_dia.ReadOnly = true;
            // 
            // reloj
            // 
            this.reloj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.reloj.FillWeight = 1F;
            this.reloj.HeaderText = "Reloj";
            this.reloj.Name = "reloj";
            this.reloj.ReadOnly = true;
            this.reloj.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.reloj.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.reloj.Width = 55;
            // 
            // evento
            // 
            this.evento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.evento.FillWeight = 1F;
            this.evento.HeaderText = "Evento";
            this.evento.Name = "evento";
            this.evento.ReadOnly = true;
            this.evento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.evento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.evento.Width = 80;
            // 
            // proxima_llegada
            // 
            this.proxima_llegada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.proxima_llegada.FillWeight = 1F;
            this.proxima_llegada.HeaderText = "Próxima Llegada";
            this.proxima_llegada.Name = "proxima_llegada";
            this.proxima_llegada.ReadOnly = true;
            this.proxima_llegada.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.proxima_llegada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.proxima_llegada.Width = 60;
            // 
            // col_elige_peluquero
            // 
            this.col_elige_peluquero.HeaderText = "Peluquero";
            this.col_elige_peluquero.Name = "col_elige_peluquero";
            this.col_elige_peluquero.ReadOnly = true;
            // 
            // col_fin_atencion_aprendiz
            // 
            this.col_fin_atencion_aprendiz.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_fin_atencion_aprendiz.FillWeight = 1F;
            this.col_fin_atencion_aprendiz.HeaderText = "Fin Atencion Aprendiz";
            this.col_fin_atencion_aprendiz.Name = "col_fin_atencion_aprendiz";
            this.col_fin_atencion_aprendiz.ReadOnly = true;
            this.col_fin_atencion_aprendiz.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_fin_atencion_aprendiz.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // con_fin_atencion_veteranoA
            // 
            this.con_fin_atencion_veteranoA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.con_fin_atencion_veteranoA.FillWeight = 1F;
            this.con_fin_atencion_veteranoA.HeaderText = "Fin Atencion Veterano A";
            this.con_fin_atencion_veteranoA.Name = "con_fin_atencion_veteranoA";
            this.con_fin_atencion_veteranoA.ReadOnly = true;
            this.con_fin_atencion_veteranoA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.con_fin_atencion_veteranoA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.con_fin_atencion_veteranoA.Width = 140;
            // 
            // col_fin_atencion_veteranoB
            // 
            this.col_fin_atencion_veteranoB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_fin_atencion_veteranoB.FillWeight = 1F;
            this.col_fin_atencion_veteranoB.HeaderText = "Fin atencion VeteranoB";
            this.col_fin_atencion_veteranoB.Name = "col_fin_atencion_veteranoB";
            this.col_fin_atencion_veteranoB.ReadOnly = true;
            this.col_fin_atencion_veteranoB.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_fin_atencion_veteranoB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_estadoAprend
            // 
            this.col_estadoAprend.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_estadoAprend.FillWeight = 1F;
            this.col_estadoAprend.HeaderText = "Estado Aprendiz";
            this.col_estadoAprend.Name = "col_estadoAprend";
            this.col_estadoAprend.ReadOnly = true;
            this.col_estadoAprend.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_estadoAprend.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_estadoAprend.Width = 60;
            // 
            // col_colaApren
            // 
            this.col_colaApren.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_colaApren.FillWeight = 1F;
            this.col_colaApren.HeaderText = "Cola Aprendiz";
            this.col_colaApren.Name = "col_colaApren";
            this.col_colaApren.ReadOnly = true;
            this.col_colaApren.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_colaApren.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_colaApren.Width = 140;
            // 
            // prcol_cant_atendidos_aprendiz
            // 
            this.prcol_cant_atendidos_aprendiz.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.prcol_cant_atendidos_aprendiz.FillWeight = 1F;
            this.prcol_cant_atendidos_aprendiz.HeaderText = "Cant Clientes Atendidos";
            this.prcol_cant_atendidos_aprendiz.Name = "prcol_cant_atendidos_aprendiz";
            this.prcol_cant_atendidos_aprendiz.ReadOnly = true;
            this.prcol_cant_atendidos_aprendiz.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.prcol_cant_atendidos_aprendiz.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.prcol_cant_atendidos_aprendiz.Width = 85;
            // 
            // col_ganancia_aprendiz
            // 
            this.col_ganancia_aprendiz.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_ganancia_aprendiz.FillWeight = 1F;
            this.col_ganancia_aprendiz.HeaderText = "Ganancia Aprendiz";
            this.col_ganancia_aprendiz.Name = "col_ganancia_aprendiz";
            this.col_ganancia_aprendiz.ReadOnly = true;
            this.col_ganancia_aprendiz.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_ganancia_aprendiz.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_ganancia_aprendiz.Width = 70;
            // 
            // col_estado_veteranoA
            // 
            this.col_estado_veteranoA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_estado_veteranoA.FillWeight = 1F;
            this.col_estado_veteranoA.HeaderText = "Estado Vererano A";
            this.col_estado_veteranoA.Name = "col_estado_veteranoA";
            this.col_estado_veteranoA.ReadOnly = true;
            this.col_estado_veteranoA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_estado_veteranoA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_estado_veteranoA.Width = 140;
            // 
            // col_colaVereranoA
            // 
            this.col_colaVereranoA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_colaVereranoA.FillWeight = 1F;
            this.col_colaVereranoA.HeaderText = "Cola Veterano A";
            this.col_colaVereranoA.Name = "col_colaVereranoA";
            this.col_colaVereranoA.ReadOnly = true;
            this.col_colaVereranoA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_colaVereranoA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_colaVereranoA.Width = 85;
            // 
            // col_cant_clien_veteranoA
            // 
            this.col_cant_clien_veteranoA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_cant_clien_veteranoA.FillWeight = 1F;
            this.col_cant_clien_veteranoA.HeaderText = "Cant Clientes Atendidos";
            this.col_cant_clien_veteranoA.Name = "col_cant_clien_veteranoA";
            this.col_cant_clien_veteranoA.ReadOnly = true;
            this.col_cant_clien_veteranoA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_cant_clien_veteranoA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_cant_clien_veteranoA.Width = 80;
            // 
            // estado_darsena_2
            // 
            this.estado_darsena_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.estado_darsena_2.FillWeight = 1F;
            this.estado_darsena_2.HeaderText = "Ganancia Veretano A";
            this.estado_darsena_2.Name = "estado_darsena_2";
            this.estado_darsena_2.ReadOnly = true;
            this.estado_darsena_2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.estado_darsena_2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.estado_darsena_2.Width = 140;
            // 
            // col_estado_veteranoB
            // 
            this.col_estado_veteranoB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_estado_veteranoB.FillWeight = 1F;
            this.col_estado_veteranoB.HeaderText = "Estado Veterano B";
            this.col_estado_veteranoB.Name = "col_estado_veteranoB";
            this.col_estado_veteranoB.ReadOnly = true;
            this.col_estado_veteranoB.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_estado_veteranoB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_estado_veteranoB.Width = 85;
            // 
            // col_colaVeteranoB
            // 
            this.col_colaVeteranoB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_colaVeteranoB.FillWeight = 1F;
            this.col_colaVeteranoB.HeaderText = "Cola Veterano B";
            this.col_colaVeteranoB.Name = "col_colaVeteranoB";
            this.col_colaVeteranoB.ReadOnly = true;
            this.col_colaVeteranoB.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_colaVeteranoB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_colaVeteranoB.Width = 80;
            // 
            // col_cant_cliVeteranoB
            // 
            this.col_cant_cliVeteranoB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_cant_cliVeteranoB.FillWeight = 1F;
            this.col_cant_cliVeteranoB.HeaderText = "Cant Clientes Atendidos";
            this.col_cant_cliVeteranoB.Name = "col_cant_cliVeteranoB";
            this.col_cant_cliVeteranoB.ReadOnly = true;
            this.col_cant_cliVeteranoB.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_cant_cliVeteranoB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_cant_cliVeteranoB.Width = 70;
            // 
            // col_gananciaVeteranoB
            // 
            this.col_gananciaVeteranoB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_gananciaVeteranoB.FillWeight = 1F;
            this.col_gananciaVeteranoB.HeaderText = "Ganancia Veterano B";
            this.col_gananciaVeteranoB.Name = "col_gananciaVeteranoB";
            this.col_gananciaVeteranoB.ReadOnly = true;
            this.col_gananciaVeteranoB.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_gananciaVeteranoB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_gananciaVeteranoB.Width = 70;
            // 
            // permanencia
            // 
            this.permanencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.permanencia.FillWeight = 1F;
            this.permanencia.HeaderText = "Cant de Clientes en Sistema";
            this.permanencia.Name = "permanencia";
            this.permanencia.ReadOnly = true;
            this.permanencia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.permanencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.permanencia.Width = 90;
            // 
            // btn_simular
            // 
            this.btn_simular.Enabled = false;
            this.btn_simular.Location = new System.Drawing.Point(1447, 779);
            this.btn_simular.Margin = new System.Windows.Forms.Padding(4);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(100, 28);
            this.btn_simular.TabIndex = 21;
            this.btn_simular.Text = "Simular";
            this.btn_simular.UseVisualStyleBackColor = true;
            this.btn_simular.Click += new System.EventHandler(this.btn_simular_Click);
            // 
            // gb_cantidades
            // 
            this.gb_cantidades.Controls.Add(this.txt_hasta);
            this.gb_cantidades.Controls.Add(this.txt_desde);
            this.gb_cantidades.Controls.Add(this.txt_dias);
            this.gb_cantidades.Controls.Add(this.lbl_dias);
            this.gb_cantidades.Controls.Add(this.lbl_hasta);
            this.gb_cantidades.Controls.Add(this.lbl_desde);
            this.gb_cantidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_cantidades.Location = new System.Drawing.Point(26, 3);
            this.gb_cantidades.Margin = new System.Windows.Forms.Padding(4);
            this.gb_cantidades.Name = "gb_cantidades";
            this.gb_cantidades.Padding = new System.Windows.Forms.Padding(4);
            this.gb_cantidades.Size = new System.Drawing.Size(239, 140);
            this.gb_cantidades.TabIndex = 20;
            this.gb_cantidades.TabStop = false;
            this.gb_cantidades.Text = "Cantidades:";
            // 
            // txt_hasta
            // 
            this.txt_hasta.Location = new System.Drawing.Point(165, 95);
            this.txt_hasta.Margin = new System.Windows.Forms.Padding(4);
            this.txt_hasta.Name = "txt_hasta";
            this.txt_hasta.Size = new System.Drawing.Size(48, 24);
            this.txt_hasta.TabIndex = 5;
            this.txt_hasta.Text = "2";
            // 
            // txt_desde
            // 
            this.txt_desde.Location = new System.Drawing.Point(165, 64);
            this.txt_desde.Margin = new System.Windows.Forms.Padding(4);
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Size = new System.Drawing.Size(48, 24);
            this.txt_desde.TabIndex = 4;
            this.txt_desde.Text = "1";
            // 
            // txt_dias
            // 
            this.txt_dias.Location = new System.Drawing.Point(165, 33);
            this.txt_dias.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dias.Name = "txt_dias";
            this.txt_dias.Size = new System.Drawing.Size(48, 24);
            this.txt_dias.TabIndex = 3;
            this.txt_dias.Text = "30";
            // 
            // lbl_dias
            // 
            this.lbl_dias.AutoSize = true;
            this.lbl_dias.Location = new System.Drawing.Point(28, 37);
            this.lbl_dias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dias.Name = "lbl_dias";
            this.lbl_dias.Size = new System.Drawing.Size(42, 18);
            this.lbl_dias.TabIndex = 2;
            this.lbl_dias.Text = "Días:";
            // 
            // lbl_hasta
            // 
            this.lbl_hasta.AutoSize = true;
            this.lbl_hasta.Location = new System.Drawing.Point(28, 97);
            this.lbl_hasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(104, 18);
            this.lbl_hasta.TabIndex = 1;
            this.lbl_hasta.Text = "Mostrar hasta:";
            // 
            // lbl_desde
            // 
            this.lbl_desde.AutoSize = true;
            this.lbl_desde.Location = new System.Drawing.Point(28, 68);
            this.lbl_desde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(108, 18);
            this.lbl_desde.TabIndex = 0;
            this.lbl_desde.Text = "Mostrar desde:";
            // 
            // gb_recalibracion
            // 
            this.gb_recalibracion.Controls.Add(this.txt_llegadaCli_hasta);
            this.gb_recalibracion.Controls.Add(this.lbl_recalibracion_varianza);
            this.gb_recalibracion.Controls.Add(this.txt_llegadaCli_desde);
            this.gb_recalibracion.Controls.Add(this.lbl_recalibracion_media);
            this.gb_recalibracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_recalibracion.Location = new System.Drawing.Point(865, 17);
            this.gb_recalibracion.Margin = new System.Windows.Forms.Padding(4);
            this.gb_recalibracion.Name = "gb_recalibracion";
            this.gb_recalibracion.Padding = new System.Windows.Forms.Padding(4);
            this.gb_recalibracion.Size = new System.Drawing.Size(167, 105);
            this.gb_recalibracion.TabIndex = 18;
            this.gb_recalibracion.TabStop = false;
            this.gb_recalibracion.Text = "Llegada Clientes:";
            // 
            // txt_llegadaCli_hasta
            // 
            this.txt_llegadaCli_hasta.Location = new System.Drawing.Point(95, 59);
            this.txt_llegadaCli_hasta.Margin = new System.Windows.Forms.Padding(4);
            this.txt_llegadaCli_hasta.Name = "txt_llegadaCli_hasta";
            this.txt_llegadaCli_hasta.Size = new System.Drawing.Size(48, 24);
            this.txt_llegadaCli_hasta.TabIndex = 3;
            this.txt_llegadaCli_hasta.Text = "12";
            // 
            // lbl_recalibracion_varianza
            // 
            this.lbl_recalibracion_varianza.AutoSize = true;
            this.lbl_recalibracion_varianza.Location = new System.Drawing.Point(23, 63);
            this.lbl_recalibracion_varianza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_recalibracion_varianza.Name = "lbl_recalibracion_varianza";
            this.lbl_recalibracion_varianza.Size = new System.Drawing.Size(69, 18);
            this.lbl_recalibracion_varianza.TabIndex = 2;
            this.lbl_recalibracion_varianza.Text = "Varianza:";
            // 
            // txt_llegadaCli_desde
            // 
            this.txt_llegadaCli_desde.Location = new System.Drawing.Point(95, 27);
            this.txt_llegadaCli_desde.Margin = new System.Windows.Forms.Padding(4);
            this.txt_llegadaCli_desde.Name = "txt_llegadaCli_desde";
            this.txt_llegadaCli_desde.Size = new System.Drawing.Size(48, 24);
            this.txt_llegadaCli_desde.TabIndex = 1;
            this.txt_llegadaCli_desde.Text = "2";
            // 
            // lbl_recalibracion_media
            // 
            this.lbl_recalibracion_media.AutoSize = true;
            this.lbl_recalibracion_media.Location = new System.Drawing.Point(23, 31);
            this.lbl_recalibracion_media.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_recalibracion_media.Name = "lbl_recalibracion_media";
            this.lbl_recalibracion_media.Size = new System.Drawing.Size(52, 18);
            this.lbl_recalibracion_media.TabIndex = 0;
            this.lbl_recalibracion_media.Text = "Media:";
            // 
            // gb_darsenas
            // 
            this.gb_darsenas.Controls.Add(this.txt_vetB_hasta);
            this.gb_darsenas.Controls.Add(this.lbl_darsenas_b);
            this.gb_darsenas.Controls.Add(this.txt_vetB_desde);
            this.gb_darsenas.Controls.Add(this.lbl_darsenas_a);
            this.gb_darsenas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_darsenas.Location = new System.Drawing.Point(675, 17);
            this.gb_darsenas.Margin = new System.Windows.Forms.Padding(4);
            this.gb_darsenas.Name = "gb_darsenas";
            this.gb_darsenas.Padding = new System.Windows.Forms.Padding(4);
            this.gb_darsenas.Size = new System.Drawing.Size(167, 105);
            this.gb_darsenas.TabIndex = 17;
            this.gb_darsenas.TabStop = false;
            this.gb_darsenas.Text = "VeteranoB:";
            // 
            // txt_vetB_hasta
            // 
            this.txt_vetB_hasta.Location = new System.Drawing.Point(95, 59);
            this.txt_vetB_hasta.Margin = new System.Windows.Forms.Padding(4);
            this.txt_vetB_hasta.Name = "txt_vetB_hasta";
            this.txt_vetB_hasta.Size = new System.Drawing.Size(48, 24);
            this.txt_vetB_hasta.TabIndex = 3;
            this.txt_vetB_hasta.Text = "18";
            // 
            // lbl_darsenas_b
            // 
            this.lbl_darsenas_b.AutoSize = true;
            this.lbl_darsenas_b.Location = new System.Drawing.Point(23, 63);
            this.lbl_darsenas_b.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_darsenas_b.Name = "lbl_darsenas_b";
            this.lbl_darsenas_b.Size = new System.Drawing.Size(22, 18);
            this.lbl_darsenas_b.TabIndex = 2;
            this.lbl_darsenas_b.Text = "B:";
            // 
            // txt_vetB_desde
            // 
            this.txt_vetB_desde.Location = new System.Drawing.Point(95, 27);
            this.txt_vetB_desde.Margin = new System.Windows.Forms.Padding(4);
            this.txt_vetB_desde.Name = "txt_vetB_desde";
            this.txt_vetB_desde.Size = new System.Drawing.Size(48, 24);
            this.txt_vetB_desde.TabIndex = 1;
            this.txt_vetB_desde.Text = "12";
            // 
            // lbl_darsenas_a
            // 
            this.lbl_darsenas_a.AutoSize = true;
            this.lbl_darsenas_a.Location = new System.Drawing.Point(23, 31);
            this.lbl_darsenas_a.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_darsenas_a.Name = "lbl_darsenas_a";
            this.lbl_darsenas_a.Size = new System.Drawing.Size(21, 18);
            this.lbl_darsenas_a.TabIndex = 0;
            this.lbl_darsenas_a.Text = "A:";
            // 
            // gb_balanza
            // 
            this.gb_balanza.Controls.Add(this.txt_vetA_hasta);
            this.gb_balanza.Controls.Add(this.lbl_balanza_b);
            this.gb_balanza.Controls.Add(this.txt_vetA_desde);
            this.gb_balanza.Controls.Add(this.lbl_balanza_a);
            this.gb_balanza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_balanza.Location = new System.Drawing.Point(482, 17);
            this.gb_balanza.Margin = new System.Windows.Forms.Padding(4);
            this.gb_balanza.Name = "gb_balanza";
            this.gb_balanza.Padding = new System.Windows.Forms.Padding(4);
            this.gb_balanza.Size = new System.Drawing.Size(167, 105);
            this.gb_balanza.TabIndex = 16;
            this.gb_balanza.TabStop = false;
            this.gb_balanza.Text = "VeteranoA:";
            // 
            // txt_vetA_hasta
            // 
            this.txt_vetA_hasta.Location = new System.Drawing.Point(95, 59);
            this.txt_vetA_hasta.Margin = new System.Windows.Forms.Padding(4);
            this.txt_vetA_hasta.Name = "txt_vetA_hasta";
            this.txt_vetA_hasta.Size = new System.Drawing.Size(48, 24);
            this.txt_vetA_hasta.TabIndex = 3;
            this.txt_vetA_hasta.Text = "13";
            // 
            // lbl_balanza_b
            // 
            this.lbl_balanza_b.AutoSize = true;
            this.lbl_balanza_b.Location = new System.Drawing.Point(23, 63);
            this.lbl_balanza_b.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_balanza_b.Name = "lbl_balanza_b";
            this.lbl_balanza_b.Size = new System.Drawing.Size(22, 18);
            this.lbl_balanza_b.TabIndex = 2;
            this.lbl_balanza_b.Text = "B:";
            // 
            // txt_vetA_desde
            // 
            this.txt_vetA_desde.Location = new System.Drawing.Point(95, 27);
            this.txt_vetA_desde.Margin = new System.Windows.Forms.Padding(4);
            this.txt_vetA_desde.Name = "txt_vetA_desde";
            this.txt_vetA_desde.Size = new System.Drawing.Size(48, 24);
            this.txt_vetA_desde.TabIndex = 1;
            this.txt_vetA_desde.Text = "11";
            // 
            // lbl_balanza_a
            // 
            this.lbl_balanza_a.AutoSize = true;
            this.lbl_balanza_a.Location = new System.Drawing.Point(23, 31);
            this.lbl_balanza_a.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_balanza_a.Name = "lbl_balanza_a";
            this.lbl_balanza_a.Size = new System.Drawing.Size(21, 18);
            this.lbl_balanza_a.TabIndex = 0;
            this.lbl_balanza_a.Text = "A:";
            // 
            // gb_recepcion
            // 
            this.gb_recepcion.Controls.Add(this.txt_aprendiz_hasta);
            this.gb_recepcion.Controls.Add(this.lbl_recepcion_b);
            this.gb_recepcion.Controls.Add(this.txt_aprendiz_desde);
            this.gb_recepcion.Controls.Add(this.lbl_recepcion_a);
            this.gb_recepcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_recepcion.Location = new System.Drawing.Point(293, 13);
            this.gb_recepcion.Margin = new System.Windows.Forms.Padding(4);
            this.gb_recepcion.Name = "gb_recepcion";
            this.gb_recepcion.Padding = new System.Windows.Forms.Padding(4);
            this.gb_recepcion.Size = new System.Drawing.Size(167, 105);
            this.gb_recepcion.TabIndex = 15;
            this.gb_recepcion.TabStop = false;
            this.gb_recepcion.Text = "Aprendiz:";
            // 
            // txt_aprendiz_hasta
            // 
            this.txt_aprendiz_hasta.Location = new System.Drawing.Point(95, 59);
            this.txt_aprendiz_hasta.Margin = new System.Windows.Forms.Padding(4);
            this.txt_aprendiz_hasta.Name = "txt_aprendiz_hasta";
            this.txt_aprendiz_hasta.Size = new System.Drawing.Size(48, 24);
            this.txt_aprendiz_hasta.TabIndex = 3;
            this.txt_aprendiz_hasta.Text = "30";
            // 
            // lbl_recepcion_b
            // 
            this.lbl_recepcion_b.AutoSize = true;
            this.lbl_recepcion_b.Location = new System.Drawing.Point(23, 63);
            this.lbl_recepcion_b.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_recepcion_b.Name = "lbl_recepcion_b";
            this.lbl_recepcion_b.Size = new System.Drawing.Size(22, 18);
            this.lbl_recepcion_b.TabIndex = 2;
            this.lbl_recepcion_b.Text = "B:";
            // 
            // txt_aprendiz_desde
            // 
            this.txt_aprendiz_desde.Location = new System.Drawing.Point(95, 27);
            this.txt_aprendiz_desde.Margin = new System.Windows.Forms.Padding(4);
            this.txt_aprendiz_desde.Name = "txt_aprendiz_desde";
            this.txt_aprendiz_desde.Size = new System.Drawing.Size(48, 24);
            this.txt_aprendiz_desde.TabIndex = 1;
            this.txt_aprendiz_desde.Text = "20";
            // 
            // lbl_recepcion_a
            // 
            this.lbl_recepcion_a.AutoSize = true;
            this.lbl_recepcion_a.Location = new System.Drawing.Point(23, 31);
            this.lbl_recepcion_a.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_recepcion_a.Name = "lbl_recepcion_a";
            this.lbl_recepcion_a.Size = new System.Drawing.Size(21, 18);
            this.lbl_recepcion_a.TabIndex = 0;
            this.lbl_recepcion_a.Text = "A:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_probVetB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_probVetA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_probAprendiz);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1049, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(321, 105);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distrib.Atencion:";
            // 
            // txt_probVetB
            // 
            this.txt_probVetB.Location = new System.Drawing.Point(265, 60);
            this.txt_probVetB.Margin = new System.Windows.Forms.Padding(4);
            this.txt_probVetB.Name = "txt_probVetB";
            this.txt_probVetB.Size = new System.Drawing.Size(48, 24);
            this.txt_probVetB.TabIndex = 5;
            this.txt_probVetB.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "VeteranoB:";
            // 
            // txt_probVetA
            // 
            this.txt_probVetA.Location = new System.Drawing.Point(113, 59);
            this.txt_probVetA.Margin = new System.Windows.Forms.Padding(4);
            this.txt_probVetA.Name = "txt_probVetA";
            this.txt_probVetA.Size = new System.Drawing.Size(48, 24);
            this.txt_probVetA.TabIndex = 3;
            this.txt_probVetA.Text = "0.60";
            this.txt_probVetA.TextChanged += new System.EventHandler(this.txt_probVetA_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "VeteranoA:";
            // 
            // txt_probAprendiz
            // 
            this.txt_probAprendiz.Location = new System.Drawing.Point(113, 27);
            this.txt_probAprendiz.Margin = new System.Windows.Forms.Padding(4);
            this.txt_probAprendiz.Name = "txt_probAprendiz";
            this.txt_probAprendiz.Size = new System.Drawing.Size(48, 24);
            this.txt_probAprendiz.TabIndex = 1;
            this.txt_probAprendiz.Text = "0.15";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Aprendiz:";
            // 
            // bnt_simular
            // 
            this.bnt_simular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_simular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_simular.Location = new System.Drawing.Point(1221, 764);
            this.bnt_simular.Name = "bnt_simular";
            this.bnt_simular.Size = new System.Drawing.Size(182, 56);
            this.bnt_simular.TabIndex = 27;
            this.bnt_simular.Text = "Generar";
            this.bnt_simular.UseVisualStyleBackColor = true;
            this.bnt_simular.Click += new System.EventHandler(this.bnt_simular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1752, 842);
            this.Controls.Add(this.bnt_simular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_actual);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btn_simular);
            this.Controls.Add(this.gb_cantidades);
            this.Controls.Add(this.gb_recalibracion);
            this.Controls.Add(this.gb_darsenas);
            this.Controls.Add(this.gb_balanza);
            this.Controls.Add(this.gb_recepcion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_actual.ResumeLayout(false);
            this.gb_actual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.gb_cantidades.ResumeLayout(false);
            this.gb_cantidades.PerformLayout();
            this.gb_recalibracion.ResumeLayout(false);
            this.gb_recalibracion.PerformLayout();
            this.gb_darsenas.ResumeLayout(false);
            this.gb_darsenas.PerformLayout();
            this.gb_balanza.ResumeLayout(false);
            this.gb_balanza.PerformLayout();
            this.gb_recepcion.ResumeLayout(false);
            this.gb_recepcion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_actual;
        private System.Windows.Forms.TextBox txt_evento;
        private System.Windows.Forms.TextBox txt_hora;
        private System.Windows.Forms.TextBox txt_dia;
        private System.Windows.Forms.Label lbl_evento;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Label lbl_dia;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btn_simular;
        private System.Windows.Forms.GroupBox gb_cantidades;
        private System.Windows.Forms.TextBox txt_hasta;
        private System.Windows.Forms.TextBox txt_desde;
        private System.Windows.Forms.TextBox txt_dias;
        private System.Windows.Forms.Label lbl_dias;
        private System.Windows.Forms.Label lbl_hasta;
        private System.Windows.Forms.Label lbl_desde;
        private System.Windows.Forms.GroupBox gb_recalibracion;
        private System.Windows.Forms.TextBox txt_llegadaCli_hasta;
        private System.Windows.Forms.Label lbl_recalibracion_varianza;
        private System.Windows.Forms.TextBox txt_llegadaCli_desde;
        private System.Windows.Forms.Label lbl_recalibracion_media;
        private System.Windows.Forms.GroupBox gb_darsenas;
        private System.Windows.Forms.TextBox txt_vetB_hasta;
        private System.Windows.Forms.Label lbl_darsenas_b;
        private System.Windows.Forms.TextBox txt_vetB_desde;
        private System.Windows.Forms.Label lbl_darsenas_a;
        private System.Windows.Forms.GroupBox gb_balanza;
        private System.Windows.Forms.TextBox txt_vetA_hasta;
        private System.Windows.Forms.Label lbl_balanza_b;
        private System.Windows.Forms.TextBox txt_vetA_desde;
        private System.Windows.Forms.Label lbl_balanza_a;
        private System.Windows.Forms.GroupBox gb_recepcion;
        private System.Windows.Forms.TextBox txt_aprendiz_hasta;
        private System.Windows.Forms.Label lbl_recepcion_b;
        private System.Windows.Forms.TextBox txt_aprendiz_desde;
        private System.Windows.Forms.Label lbl_recepcion_a;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_probVetB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_probVetA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_probAprendiz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bnt_simular;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn reloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn proxima_llegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_elige_peluquero;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fin_atencion_aprendiz;
        private System.Windows.Forms.DataGridViewTextBoxColumn con_fin_atencion_veteranoA;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fin_atencion_veteranoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_estadoAprend;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_colaApren;
        private System.Windows.Forms.DataGridViewTextBoxColumn prcol_cant_atendidos_aprendiz;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ganancia_aprendiz;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_estado_veteranoA;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_colaVereranoA;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cant_clien_veteranoA;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_darsena_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_estado_veteranoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_colaVeteranoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cant_cliVeteranoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gananciaVeteranoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn permanencia;
    }
}

