using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListEncadeada
{
    public partial class AlocacaoMemoria : Form
    {
        private enum POSICAO{
            INICIO,
            FIM
        }

        private struct Node
        {
            public int pid;
            public string status;
            public int tamanhoAlocacao;
            public Node(int _pid, string _status, int _tamanhoAlocacao)
            {
                this.pid = _pid;
                this.status = _status;
                this.tamanhoAlocacao = _tamanhoAlocacao;
            }
        }

        public AlocacaoMemoria()
        {
            InitializeComponent();
            Inicializa(ref nodeList);
        }
        const string msgNaoEncontrado = "PID não encontrado!";

        private string msSucesso = "Ação realizada com sucesso";
        private ListaEncadeada<Node> nodeList;

        // Função que inicializa
        void Inicializa(ref ListaEncadeada<Node> nodeList)
        {
            nodeList = null;
        }

        // Incluir
        void Insere(POSICAO pos, Node no)
        {
            if(nodeList == null)
                nodeList = ListaEncadeada<Node>.createListaEncadeada(no);
            else
            {
                if (pos == POSICAO.INICIO)
                    nodeList.addElementAtBegin(no);
                else
                    nodeList.addElementAtEnd(no);
            }
        }
        public void btGravarInclusao_Click(object sender, EventArgs e)
        {
            Node node = new Node(Convert.ToInt32(tbPIDInclusao.Text), "Processo", Convert.ToInt32(tbTamanhoAlocacaoInclusao.Text)); //alocar memória, cria uma instância
            Insere(POSICAO.INICIO, node);
            tbPIDInclusao.Clear();
            tbTamanhoAlocacaoInclusao.Clear();
            tbPIDInclusao.Focus();

        }
        //Incluir First-Fit
        void InsereFirstFit(Node no)
        {
        /*
            if (inicio == null)
                inicio = no;
            else { 
                int i = 0;
                anterior = null;
                atual = inicio; //auxiliar para não sobrescrever
                while (atual != null)
                {
                    if (atual.status == "Livre" && atual.tamanhoAlocacao > no.tamanhoAlocacao)
                    {
                        anterior.prox = no;
                        atual.tamanhoAlocacao -= no.tamanhoAlocacao;
                        no.prox = atual;
                        i = 1;
                        break;
                    }
                    else if (atual.status == "Livre" && atual.tamanhoAlocacao == no.tamanhoAlocacao)
                    {
                        anterior.prox = no;
                        no.prox = atual.prox;
                        atual.prox = null;
                        i = 1;
                        break;
                    }
                    anterior = atual;
                    atual = atual.prox;
                }
                if (i == 0) InsereNoFim(ref inicio, no);
            }
        */
    }
    private void btGravarFirstFit_Click(object sender, EventArgs e)
        {
            Node node = new Node(); //alocar memória, cria uma instância
            node.pid = Convert.ToInt32(tbPIDInclusao.Text);
            node.status = "Processo";
            node.tamanhoAlocacao = Convert.ToInt32(tbTamanhoAlocacaoInclusao.Text);
            InsereFirstFit(node);

            tbPIDInclusao.Clear();
            tbTamanhoAlocacaoInclusao.Clear();
            tbPIDInclusao.Focus();
        }

        private void btGravaNoFim_Click(object sender, EventArgs e)
        {
            Node node = new Node(Convert.ToInt32(tbPIDInclusao.Text), "Processo", Convert.ToInt32(tbTamanhoAlocacaoInclusao.Text)); //alocar memória, cria uma instância
            Insere(POSICAO.FIM, node);
            tbPIDInclusao.Clear();
            tbTamanhoAlocacaoInclusao.Clear();
            tbPIDInclusao.Focus();
        }

        //busca sequencial
        void Consulta(int pid)
        {
            anterior = null;
            atual = inicio; //auxiliar para não sobrescrever
            while (atual != null && pid != atual.pid)
            {
                anterior = atual;
                atual = atual.prox;
            }
        }
        //liberar memória
        private void btConsultaPIDLiberarOnClick(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(tbPIDConsultaCompactar.Text);
            Consulta(pid);

            if (atual != null)
            {
                tbPIDAlteracao.Text = Convert.ToString(atual.pid);
                tbTamanhoAlteracao.Text = Convert.ToString(atual.tamanhoAlocacao);
            }
            else
                MessageBox.Show(msgNaoEncontrado);
        }
        private void btLiberarMemoria_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(tbPIDConsultaCompactar.Text);
            Consulta(pid);

            if (atual != null)
            {
                atual.pid = -1;
                atual.status = "Livre";
                MessageBox.Show(msSucesso); 
            }
            else
                MessageBox.Show(msgNaoEncontrado);
            tbPIDAlteracao.Clear();
            tbTamanhoAlteracao.Clear();
            tbPIDConsultaCompactar.Focus();
        }
        //exibir
        private void btExibeRegistros_Click(object sender, EventArgs e)
        {
            lbExibeRegistros.Items.Clear();
            Exibir();

        }
        void Exibir()
        {
            atual = inicio;
            while (atual != null)
            {
                if (atual.status == "Processo")
                {
                    lbExibeRegistros.Items.Add($" PID: {atual.pid}.");
                    lbExibeRegistros.Items.Add($" Tamanho alocado: {atual.tamanhoAlocacao}kb.");
                    lbExibeRegistros.Items.Add(" ");
                }
                else
                {
                    lbExibeRegistros.Items.Add($" Estado: {atual.status}.");
                    lbExibeRegistros.Items.Add($" Tamanho desalocado: {atual.tamanhoAlocacao}kb.");
                    lbExibeRegistros.Items.Add(" ");
                }
                atual = atual.prox;
            }
        }
        //compactar áreas adjacentes
        private void btCompactarAdj_Click(object sender, EventArgs e)
        {
            Compactar(ref inicio);
        }
        void Compactar(ref Node inicio)
        {
            anterior = null;
            atual = inicio;
            while (atual != null)
            {
                anterior = atual;
                atual = atual.prox;
                if (anterior.status == "Livre" && anterior.status == atual.status)
                {
                    anterior.tamanhoAlocacao += atual.tamanhoAlocacao;
                    anterior.prox = atual.prox;
                    atual.prox = null;
                    Compactar(ref inicio);
                    MessageBox.Show(msSucesso);
                }
                else
                    MessageBox.Show("Não há fragmentos livre adjacentes para compactação!");
            }
        }
        private void btEsvaziar_Click(object sender, EventArgs e)
        {
            //inicio = null;
            while (inicio != null)
            {
                atual = inicio;
                inicio = inicio.prox;
                atual.prox = null;
            }
            MessageBox.Show(msSucesso); 
        }
    }
}
