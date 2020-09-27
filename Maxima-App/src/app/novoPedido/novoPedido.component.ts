import { Component, OnInit } from '@angular/core';
import { MinLengthValidator, Validators } from '@angular/forms';
import { NovoPedidoService } from '../_services/novoPedido.service';

@Component({
  selector: 'app-novoPedido',
  templateUrl: './novoPedido.component.html',
  styleUrls: ['./novoPedido.component.css']
})
export class NovoPedidoComponent implements OnInit {

  cliente: any[];
  produto: any [];

  constructor(private novoPedidoService: NovoPedidoService) { }

  ngOnInit() {
  }
  getCliente() {
    this.novoPedidoService.getCliente().subscribe(response => {
      this.cliente = response;
    }, error => {
      console.log(error);
    });
  }
  getProduto() {
    this.novoPedidoService.getProduto().subscribe(response => {
      this.produto = response;
    }, error => {
      console.log(error);
    });
  }

}
