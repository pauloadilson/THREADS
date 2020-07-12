namespace ListEncadeada
{
    partial class AlocacaoMemoria
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tcListaEncadeada = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btGravarFirstFit = new System.Windows.Forms.Button();
            this.btGravarInclusao = new System.Windows.Forms.Button();
            this.tbTamanhoAlocacaoInclusao = new System.Windows.Forms.TextBox();
            this.tbPIDInclusao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LRecebeDecimal = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btConsultaAlteracao = new System.Windows.Forms.Button();
            this.btGravarAlteracao = new System.Windows.Forms.Button();
            this.tbTamanhoAlteracao = new System.Windows.Forms.TextBox();
            this.tbPIDConsultaCompactar = new System.Windows.Forms.TextBox();
            this.tbPIDAlteracao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btEsvaziar = new System.Windows.Forms.Button();
            this.btCompactarAdj = new System.Windows.Forms.Button();
            this.lbExibeRegistros = new System.Windows.Forms.ListBox();
            this.btExibeRegistros = new System.Windows.Forms.Button();
            this.btGravaNoFim = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tcListaEncadeada.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tcListaEncadeada);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 461);
            this.panel1.TabIndex = 0;
            // 
            // tcListaEncadeada
            // 
            this.tcListaEncadeada.Controls.Add(this.tabPage1);
            this.tcListaEncadeada.Controls.Add(this.tabPage2);
            this.tcListaEncadeada.Controls.Add(this.tabPage4);
            this.tcListaEncadeada.Location = new System.Drawing.Point(3, 3);
            this.tcListaEncadeada.Multiline = true;
            this.tcListaEncadeada.Name = "tcListaEncadeada";
            this.tcListaEncadeada.SelectedIndex = 0;
            this.tcListaEncadeada.Size = new System.Drawing.Size(478, 455);
            this.tcListaEncadeada.TabIndex = 0;
            this.tcListaEncadeada.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btGravarFirstFit);
            this.tabPage1.Controls.Add(this.btGravaNoFim);
            this.tabPage1.Controls.Add(this.btGravarInclusao);
            this.tabPage1.Controls.Add(this.tbTamanhoAlocacaoInclusao);
            this.tabPage1.Controls.Add(this.tbPIDInclusao);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.LRecebeDecimal);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(470, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Incluir";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btGravarFirstFit
            // 
            this.btGravarFirstFit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btGravarFirstFit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btGravarFirstFit.FlatAppearance.BorderSize = 0;
            this.btGravarFirstFit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGravarFirstFit.Location = new System.Drawing.Point(167, 223);
            this.btGravarFirstFit.Margin = new System.Windows.Forms.Padding(2);
            this.btGravarFirstFit.Name = "btGravarFirstFit";
            this.btGravarFirstFit.Size = new System.Drawing.Size(150, 32);
            this.btGravarFirstFit.TabIndex = 5;
            this.btGravarFirstFit.Text = "Gravar First-fit";
            this.btGravarFirstFit.UseVisualStyleBackColor = false;
            this.btGravarFirstFit.Click += new System.EventHandler(this.btGravarFirstFit_Click);
            // 
            // btGravarInclusao
            // 
            this.btGravarInclusao.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btGravarInclusao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btGravarInclusao.FlatAppearance.BorderSize = 0;
            this.btGravarInclusao.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGravarInclusao.Location = new System.Drawing.Point(167, 119);
            this.btGravarInclusao.Margin = new System.Windows.Forms.Padding(2);
            this.btGravarInclusao.Name = "btGravarInclusao";
            this.btGravarInclusao.Size = new System.Drawing.Size(150, 32);
            this.btGravarInclusao.TabIndex = 3;
            this.btGravarInclusao.Text = "Gravar no início";
            this.btGravarInclusao.UseVisualStyleBackColor = false;
            this.btGravarInclusao.Click += new System.EventHandler(this.btGravarInclusao_Click);
            // 
            // tbTamanhoAlocacaoInclusao
            // 
            this.tbTamanhoAlocacaoInclusao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTamanhoAlocacaoInclusao.Location = new System.Drawing.Point(235, 67);
            this.tbTamanhoAlocacaoInclusao.Margin = new System.Windows.Forms.Padding(2);
            this.tbTamanhoAlocacaoInclusao.Name = "tbTamanhoAlocacaoInclusao";
            this.tbTamanhoAlocacaoInclusao.Size = new System.Drawing.Size(164, 22);
            this.tbTamanhoAlocacaoInclusao.TabIndex = 2;
            // 
            // tbPIDInclusao
            // 
            this.tbPIDInclusao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPIDInclusao.Location = new System.Drawing.Point(235, 23);
            this.tbPIDInclusao.Margin = new System.Windows.Forms.Padding(2);
            this.tbPIDInclusao.Name = "tbPIDInclusao";
            this.tbPIDInclusao.Size = new System.Drawing.Size(97, 22);
            this.tbPIDInclusao.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tamanho de Alocação (kb):";
            // 
            // LRecebeDecimal
            // 
            this.LRecebeDecimal.AutoSize = true;
            this.LRecebeDecimal.BackColor = System.Drawing.Color.Transparent;
            this.LRecebeDecimal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRecebeDecimal.Location = new System.Drawing.Point(197, 24);
            this.LRecebeDecimal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LRecebeDecimal.Name = "LRecebeDecimal";
            this.LRecebeDecimal.Size = new System.Drawing.Size(34, 19);
            this.LRecebeDecimal.TabIndex = 6;
            this.LRecebeDecimal.Text = "PID:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btConsultaAlteracao);
            this.tabPage2.Controls.Add(this.btGravarAlteracao);
            this.tabPage2.Controls.Add(this.tbTamanhoAlteracao);
            this.tabPage2.Controls.Add(this.tbPIDConsultaCompactar);
            this.tabPage2.Controls.Add(this.tbPIDAlteracao);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(470, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Liberar Memória";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btConsultaAlteracao
            // 
            this.btConsultaAlteracao.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btConsultaAlteracao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btConsultaAlteracao.FlatAppearance.BorderSize = 0;
            this.btConsultaAlteracao.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultaAlteracao.Location = new System.Drawing.Point(102, 62);
            this.btConsultaAlteracao.Margin = new System.Windows.Forms.Padding(2);
            this.btConsultaAlteracao.Name = "btConsultaAlteracao";
            this.btConsultaAlteracao.Size = new System.Drawing.Size(97, 32);
            this.btConsultaAlteracao.TabIndex = 2;
            this.btConsultaAlteracao.Text = "Procurar";
            this.btConsultaAlteracao.UseVisualStyleBackColor = false;
            this.btConsultaAlteracao.Click += new System.EventHandler(this.btConsultaPIDLiberarOnClick);
            // 
            // btGravarAlteracao
            // 
            this.btGravarAlteracao.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btGravarAlteracao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btGravarAlteracao.FlatAppearance.BorderSize = 0;
            this.btGravarAlteracao.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGravarAlteracao.Location = new System.Drawing.Point(102, 223);
            this.btGravarAlteracao.Margin = new System.Windows.Forms.Padding(2);
            this.btGravarAlteracao.Name = "btGravarAlteracao";
            this.btGravarAlteracao.Size = new System.Drawing.Size(97, 32);
            this.btGravarAlteracao.TabIndex = 6;
            this.btGravarAlteracao.Text = "Liberar";
            this.btGravarAlteracao.UseVisualStyleBackColor = false;
            this.btGravarAlteracao.Click += new System.EventHandler(this.btLiberarMemoria_Click);
            // 
            // tbTamanhoAlteracao
            // 
            this.tbTamanhoAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTamanhoAlteracao.Location = new System.Drawing.Point(102, 183);
            this.tbTamanhoAlteracao.Margin = new System.Windows.Forms.Padding(2);
            this.tbTamanhoAlteracao.Name = "tbTamanhoAlteracao";
            this.tbTamanhoAlteracao.Size = new System.Drawing.Size(164, 22);
            this.tbTamanhoAlteracao.TabIndex = 4;
            // 
            // tbPIDConsultaCompactar
            // 
            this.tbPIDConsultaCompactar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPIDConsultaCompactar.Location = new System.Drawing.Point(102, 25);
            this.tbPIDConsultaCompactar.Margin = new System.Windows.Forms.Padding(2);
            this.tbPIDConsultaCompactar.Name = "tbPIDConsultaCompactar";
            this.tbPIDConsultaCompactar.Size = new System.Drawing.Size(280, 22);
            this.tbPIDConsultaCompactar.TabIndex = 1;
            // 
            // tbPIDAlteracao
            // 
            this.tbPIDAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPIDAlteracao.Location = new System.Drawing.Point(102, 141);
            this.tbPIDAlteracao.Margin = new System.Windows.Forms.Padding(2);
            this.tbPIDAlteracao.Name = "tbPIDAlteracao";
            this.tbPIDAlteracao.Size = new System.Drawing.Size(280, 22);
            this.tbPIDAlteracao.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "PID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tamanho:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "PID:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btEsvaziar);
            this.tabPage4.Controls.Add(this.btCompactarAdj);
            this.tabPage4.Controls.Add(this.lbExibeRegistros);
            this.tabPage4.Controls.Add(this.btExibeRegistros);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(470, 429);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Exibir, Compactar e Esvaziar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btEsvaziar
            // 
            this.btEsvaziar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btEsvaziar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btEsvaziar.FlatAppearance.BorderSize = 0;
            this.btEsvaziar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEsvaziar.Location = new System.Drawing.Point(330, 28);
            this.btEsvaziar.Margin = new System.Windows.Forms.Padding(2);
            this.btEsvaziar.Name = "btEsvaziar";
            this.btEsvaziar.Size = new System.Drawing.Size(111, 32);
            this.btEsvaziar.TabIndex = 29;
            this.btEsvaziar.Text = "Esvaziar lista";
            this.btEsvaziar.UseVisualStyleBackColor = false;
            this.btEsvaziar.Click += new System.EventHandler(this.btEsvaziar_Click);
            // 
            // btCompactarAdj
            // 
            this.btCompactarAdj.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btCompactarAdj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btCompactarAdj.FlatAppearance.BorderSize = 0;
            this.btCompactarAdj.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCompactarAdj.Location = new System.Drawing.Point(135, 28);
            this.btCompactarAdj.Margin = new System.Windows.Forms.Padding(2);
            this.btCompactarAdj.Name = "btCompactarAdj";
            this.btCompactarAdj.Size = new System.Drawing.Size(191, 32);
            this.btCompactarAdj.TabIndex = 28;
            this.btCompactarAdj.Text = "Compactar adjacências";
            this.btCompactarAdj.UseVisualStyleBackColor = false;
            this.btCompactarAdj.Click += new System.EventHandler(this.btCompactarAdj_Click);
            // 
            // lbExibeRegistros
            // 
            this.lbExibeRegistros.FormattingEnabled = true;
            this.lbExibeRegistros.Location = new System.Drawing.Point(28, 83);
            this.lbExibeRegistros.Name = "lbExibeRegistros";
            this.lbExibeRegistros.Size = new System.Drawing.Size(413, 303);
            this.lbExibeRegistros.TabIndex = 26;
            // 
            // btExibeRegistros
            // 
            this.btExibeRegistros.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btExibeRegistros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btExibeRegistros.FlatAppearance.BorderSize = 0;
            this.btExibeRegistros.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExibeRegistros.Location = new System.Drawing.Point(28, 28);
            this.btExibeRegistros.Margin = new System.Windows.Forms.Padding(2);
            this.btExibeRegistros.Name = "btExibeRegistros";
            this.btExibeRegistros.Size = new System.Drawing.Size(103, 32);
            this.btExibeRegistros.TabIndex = 1;
            this.btExibeRegistros.Text = "Exibir Todos";
            this.btExibeRegistros.UseVisualStyleBackColor = false;
            this.btExibeRegistros.Click += new System.EventHandler(this.btExibeRegistros_Click);
            // 
            // btGravaNoFim
            // 
            this.btGravaNoFim.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btGravaNoFim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btGravaNoFim.FlatAppearance.BorderSize = 0;
            this.btGravaNoFim.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGravaNoFim.Location = new System.Drawing.Point(167, 171);
            this.btGravaNoFim.Margin = new System.Windows.Forms.Padding(2);
            this.btGravaNoFim.Name = "btGravaNoFim";
            this.btGravaNoFim.Size = new System.Drawing.Size(150, 32);
            this.btGravaNoFim.TabIndex = 4;
            this.btGravaNoFim.Text = "Gravar no fim";
            this.btGravaNoFim.UseVisualStyleBackColor = false;
            this.btGravaNoFim.Click += new System.EventHandler(this.btGravaNoFim_Click);
            // 
            // AlocacaoMemoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.panel1);
            this.Name = "AlocacaoMemoria";
            this.Text = "Ex. 17 - Lista Encadeada";
            this.panel1.ResumeLayout(false);
            this.tcListaEncadeada.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tcListaEncadeada;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox tbTamanhoAlocacaoInclusao;
        private System.Windows.Forms.TextBox tbPIDInclusao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LRecebeDecimal;
        private System.Windows.Forms.Button btGravarInclusao;
        private System.Windows.Forms.Button btConsultaAlteracao;
        private System.Windows.Forms.Button btGravarAlteracao;
        private System.Windows.Forms.TextBox tbTamanhoAlteracao;
        private System.Windows.Forms.TextBox tbPIDConsultaCompactar;
        private System.Windows.Forms.TextBox tbPIDAlteracao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbExibeRegistros;
        private System.Windows.Forms.Button btExibeRegistros;
        private System.Windows.Forms.Button btCompactarAdj;
        private System.Windows.Forms.Button btEsvaziar;
        private System.Windows.Forms.Button btGravarFirstFit;
        private System.Windows.Forms.Button btGravaNoFim;
    }
}
