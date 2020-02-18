import { Component, OnInit } from '@angular/core';
import { ProdutoService } from 'src/app/services/produto.service';
import { Produto } from 'src/app/models/produto';
import { error } from 'util';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'BOL-lista-produtos',
  templateUrl: './lista-produtos.component.html',
})
export class ListaProdutosComponent implements OnInit {

  public listaProdutos: Produto[];
  
  constructor(private route: ActivatedRoute) { }

  ngOnInit() {
    // this.service.obterProdutos().subscribe(prd=>{
    //     this.listaProdutos = prd
    //     console.log(prd);
    // },
    //     error => console.log(error)
    // );
    this.listaProdutos = this.route.snapshot.data['produtos'];
  }

  produtoSelecionado(prd: Produto){
    console.log('=>', prd);

    prd.promocao = !prd.promocao;
  }

}
