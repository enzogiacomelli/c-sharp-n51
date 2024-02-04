﻿using SupermercadoForm.Repositorios;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
namespace SupermercadoForm.Telas
{
    public partial class EstoqueListaForm : Form
    {
        public EstoqueListaForm()
        {
            InitializeComponent();
        }

        private void EstoqueListaForm_Load(object sender, EventArgs e)
        {
            ListaEstoquesNoGrid();
        }

        private void ListaEstoquesNoGrid()
        {
            dataGridViewEstoques.Rows.Clear();

            var estoqueRepositorio = new EstoqueRepositorio();
            var estoques = estoqueRepositorio.ObterTodos();

            for (int i = 0; i < estoques.Count; i++)
            {
                var estoque = estoques[i];
                dataGridViewEstoques.Rows.Add(new object[]
                {
                    estoque.Id,
                    estoque.Produto.Id,
                    estoque.Produto.Nome,
                    estoque.Quantidade
                });
            }
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            var form = new EstoqueCadastroForm();
            form.ShowDialog();
        }
    }
}
