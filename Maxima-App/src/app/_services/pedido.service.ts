import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Pedido } from '../_models/Pedido';

@Injectable({
  providedIn: 'root'
})
export class PedidoService {
  baseURL = 'http://localhost:5000/api/pedido';

  constructor(private http: HttpClient) {}

  //Busca todos os pedidos
  getPedidos():Observable<Pedido[]>{
    return this.http.get<Pedido[]>(this.baseURL);

  }
}


