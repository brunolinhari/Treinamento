import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs';
import { Produto } from '../models/produto';

@Injectable({
  providedIn: 'root'
})
export class ProdutoService {

  protected urlApi: string = "http://localhost:3000/produtos"

  constructor(private http: HttpClient) {}

  obterProduto(): Observable<Produto[]>{
    return this.http.get<Produto[]>(this.urlApi);
  }
}
