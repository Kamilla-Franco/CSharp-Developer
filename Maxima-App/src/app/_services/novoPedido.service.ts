import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Cliente } from '../_models/Cliente';
import { Produto } from '../_models/Produto';

@Injectable({
  providedIn: 'root'
})
export class NovoPedidoService {
  clienteURL: 'http://localhost:5000/api/cliente';
  produtoURL: 'http://localhost:5000/api/produto';

  constructor(private http: HttpClient) {}

  getCliente(): Observable<Cliente[]>{
    return this.http.get<Cliente[]>(this.clienteURL);

  }
  getProduto(): Observable<Produto[]>{
    return this.http.get<Produto[]>(this.produtoURL);

  }

}
