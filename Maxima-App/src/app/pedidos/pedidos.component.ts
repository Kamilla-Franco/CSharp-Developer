import { Component, OnInit } from '@angular/core';
import { PedidoService } from '../_services/pedido.service';

@Component({
  selector: 'app-pedidos',
  templateUrl: './pedidos.component.html',
  styleUrls: ['./pedidos.component.css']
})
export class PedidosComponent implements OnInit {

  public pedidos: any = [];

  constructor(private pedidoService: PedidoService) { }

  ngOnInit() {
    this.getPedidos();
  }

  getPedidos() {
    this.pedidoService.getPedidos().subscribe(response => {
      this.pedidos = response;
    }, error => {
      console.log(error);
    });
  }
}
