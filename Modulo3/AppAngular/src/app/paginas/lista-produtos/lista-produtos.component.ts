import { Component, OnInit } from '@angular/core';
import { ProdutoService } from 'src/app/services/produto.service';
import { Produto } from 'src/app/models/produto';
import { error } from 'util';

@Component({
  selector: 'BOL-lista-produtos',
  templateUrl: './lista-produtos.component.html',
})
export class ListaProdutosComponent implements OnInit {

  public listaProdutos: Produto[];
  constructor(private service: ProdutoService) { }

  ngOnInit() {
    this.service.obterProduto().subscribe(prd=>{
        this.listaProdutos = prd
        console.log(prd);
    },
        error => console.log(error)
    );
  }

}
