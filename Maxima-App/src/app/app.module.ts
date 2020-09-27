import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule} from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';

import{BsDropdownModule } from 'ngx-bootstrap/dropdown';

import { AppComponent } from './app.component';
import { PedidosComponent } from './pedidos/pedidos.component';
import { NavComponent } from './nav/nav.component';
import { NovoPedidoComponent } from './novoPedido/novoPedido.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
  declarations: [
    AppComponent,
      PedidosComponent,
      NavComponent,
      NovoPedidoComponent
   ],
  imports: [
    BrowserModule,
    BsDropdownModule.forRoot(),
    HttpClientModule,    
    AppRoutingModule,
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
