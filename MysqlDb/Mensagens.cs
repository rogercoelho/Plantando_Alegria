using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plantando_Alegria.MysqlDb
{
    internal class Mensagens
    {
        public void Mensagem_01()
        {
            MessageBox.Show("*** ATENÇÃO *** \n" +
                            "A pesquisa dos campos em branco retorna todas as informações da tabela.\n" +
                            "Esta pesquisa pode demorar muito ou até travar, dependendo da quantidade de informações!",
                            "Plantando Alegria - *** ATENÇÃO ***", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void Mensagem_02()
        {
            MessageBox.Show("Não foi encontrado nenhum registro com os dados informados.\n",
                            "Plantando Alegria - Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Mensagem_03()
        {
            MessageBox.Show("Pesquisa realizada com sucesso!\n",
                            "Plantando Alegria - Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Mensagem_04(string erromsg)
        {
            MessageBox.Show("Ocorreu um erro ao tentar efetuar a pesquisa.\n" + erromsg,
                            "Plantando Alegria - Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Mensagem_05()
        {
            MessageBox.Show("A pesquisa irá efetuar a busca pelo código OU pelo nome do aluno.\n",
                            "Plantando Alegria - Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Mensagem_06()
        {
            MessageBox.Show("A imagem foi salva com sucesso.\n" +
                            "Cadastro do Aluno finalizado.\n", "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Mensagem_07()
        {
            MessageBox.Show("Nao houve alterações na ficha do aluno.\n" +
                            "Não existe nada para salvar!.\n", "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Mensagem_08()
        {
            MessageBox.Show("Os dados da ficha do aluno foram atualizados com sucesso.\n",
                            "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Mensagem_09()
        {
            MessageBox.Show("A foto do aluno foi atualizada com sucesso.\n",
                            "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Mensagem_10()
        {
            MessageBox.Show("Os dados e a foto do aluno foram atualizados com sucesso.\n",
                            "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Mensagem_11()
        {
            MessageBox.Show("Aluno cadastrado com sucesso..\n",
                            "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Mensagem_12()
        {
            MessageBox.Show("O campo de Código do Aluno aceita apenas numeros e não pode estar vazio.\n",
                            "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Mensagem_13()
        {
            MessageBox.Show("O campo Nome do Aluno não pode estar vazio.\n",
                            "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Mensagem_14()
        {
            MessageBox.Show("O Campo Endereco do Aluno não pode estar vazio.\n",
                            "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Mensagem_15()
        {
            MessageBox.Show("O Campo Bairro não pode estar vazio.\n",
                            "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Mensagem_16()
        {
            MessageBox.Show("O Campo Cidade não pode estar vazio.\n",
                            "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Mensagem_17()
        {
            MessageBox.Show("O Campo CEP não pode estar vazio.\n",
                            "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Mensagem_18()
        {
            MessageBox.Show("O campo Telefone do Aluno não pode estar vazio.\n",
                            "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Mensagem_19()
        {
            MessageBox.Show("O Campo Email do Aluno não pode estar vazio\n",
                            "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Mensagem_20()
        {
            MessageBox.Show("O Campo Contado de Emergência não pode estar vazio.\n",
                            "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Mensagem_21()
        {
            MessageBox.Show("O Campo Telefone do Contato de Emergência não pode estar vazio.\n",
                            "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Mensagem_22(string erromsg)
        {
            MessageBox.Show("Erro ao Efetuar Cadastro.\n" + erromsg,
                            "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void Mensagem_23()
        {
            MessageBox.Show("O Campo Código do Plano não pode estar vazio.\n",
                            "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Mensagem_24()
        {
            MessageBox.Show("O Campo Nome do Plano não pode estar vazio.\n",
                            "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Mensagem_25()
        {
            MessageBox.Show("O Campo Quantidade de Aulas na Semana aceita apenas números e não pode estar vazio.\n",
                            "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Mensagem_26()
        {
            MessageBox.Show("O Campo Quantidade Total de Aulas do Plano aceita apenas números e não pode estar vazio.\n",
                            "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Mensagem_27()
        {
            MessageBox.Show("O Campo Valor Mensal do Plano aceita apenas valor e não pode estar vazio.\n",
                            "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Mensagem_28()
        {
            MessageBox.Show("O Campo Valor Total do Plano aceita apenas valor e não pode estar vazio.\n",
                            "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Mensagem_29()
        {
            MessageBox.Show("Plano " + DB_PA.planos_codigo + " de nome " + DB_PA.planos_nome + " cadastrado com sucesso.\n",
                            "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Mensagem_30()
        {
            MessageBox.Show("A pesquisa irá efetuar a busca pelo código OU pelo nome do plano.\n",
                            "Plantando Alegria - Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Mensagem_31()
        {
            MessageBox.Show("Nao houve alterações na ficha do plano.\n" +
                            "Não existe nada para salvar!.\n", "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Mensagem_32()
        {
            MessageBox.Show("Não é possível deixar a situação do plano em branco.\n" +
                            "Por favor, selecione ATIVO ou INATIVO.\n", "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Mensagem_33()
        {
            MessageBox.Show("Os dados da ficha do plano foram atualizados com sucesso.\n",
                            "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Mensagem_34()
        {
            MessageBox.Show("O campo de CPF do Aluno aceita apenas numeros e não pode estar vazio.\n",
                            "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
