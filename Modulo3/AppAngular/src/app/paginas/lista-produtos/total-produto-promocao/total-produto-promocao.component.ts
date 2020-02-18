import { Component, OnInit, Input } from '@angular/core';
import { Produto } from 'src/app/models/produto';

@Component({
  selector: 'BOL-total-produto-promocao',
  templateUrl: './total-produto-promocao.component.html',
  styles: []
})
export class TotalProdutoPromocaoComponent implements OnInit {

  @Input()
  produtos: Produto[];

  constructor() { }

  ngOnInit() {
  }

  qtdePromocao(): number{
    if(!this.produtos) return;

    return this.produtos.filter(p=>p.promocao).length;
  }

}
