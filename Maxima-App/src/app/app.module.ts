import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule} from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import{BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { FormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';


import { AppComponent } from './app.component';
import { PedidosComponent } from './pedidos/pedidos.component';
import { NavComponent } from './nav/nav.component';
import { NovoPedidoComponent } from './novoPedido/novoPedido.component';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
      PedidosComponent,
      NovoPedidoComponent
   ],
  imports: [
    BrowserModule,
    BsDropdownModule.forRoot(),
    HttpClientModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
