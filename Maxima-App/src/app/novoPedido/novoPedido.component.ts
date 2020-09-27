import { Component, OnInit } from '@angular/core';
import { Cliente } from '../_models/Cliente';
import { Produto } from '../_models/Produto';
import { NovoPedidoService } from '../_services/novoPedido.service';

@Component({
  selector: 'app-novoPedido',
  templateUrl: './novoPedido.component.html',
  styleUrls: ['./novoPedido.component.css']
})
export class NovoPedidoComponent implements OnInit {

  _filtroLista = '';

  get filtroLista(): string{
    return this._filtroLista;
  }
  set filtroLista(value: string){
    this._filtroLista = value;
    this.clientesFiltrados = this.filtroLista ? this.filtrarCLientes(this.filtroLista) : this.cliente;
  }

  clientesFiltrados: Cliente[];
  cliente: Cliente[];
  produto: Produto[];

  constructor(private novoPedidoService: NovoPedidoService) { }

  ngOnInit() {
    this.getCliente();
    this.getProduto();
  }
  getCliente() {
    this.novoPedidoService.getCliente().subscribe(
      (_cliente: Cliente[]) => {
        this.cliente = _cliente;
        console.log(_cliente);
      }, error => {
        console.log(error);
      });
    }
    getProduto() {
      this.novoPedidoService.getProduto().subscribe(
        (_produto: Produto[]) => {
          this.produto = _produto;
          console.log(_produto);
        }, error => {
          console.log(error);
        });
      }
      filtrarCLientes(filtrarPor: string): Cliente[]{
        filtrarPor = filtrarPor.toLocaleLowerCase();
        return this.cliente.filter(
          cliente => cliente.nome.toLocaleLowerCase().indexOf(filtrarPor) !== 1
          );
        }

      }
