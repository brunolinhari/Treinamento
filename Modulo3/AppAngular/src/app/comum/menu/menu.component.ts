import { Component, OnInit } from '@angular/core';
import { Navegacao } from './navegacao';

@Component({
  selector: 'BOL-menu',
  templateUrl: './menu.component.html',
})
export class MenuComponent implements OnInit {

  Menu: Navegacao[] = [];
  
  constructor() { }

  ngOnInit() {
    this.Menu.push({descricao: 'Cadastro', icone: 'fa fa-sign-language', link: '/cadastro'});
    this.Menu.push({descricao: 'Data Binding', icone: 'fa fa-sign-language', link: '/data-binding'});
    this.Menu.push({descricao: 'Contato', icone: 'fa fa-child', link: '/contato'});
    this.Menu.push({descricao: 'Produtos', icone: 'fa fa-id-card', link: '/produtos'});
    this.Menu.push({descricao: 'Admin', icone: 'fa fa-cogs', link: '/admin'});
  }
}
