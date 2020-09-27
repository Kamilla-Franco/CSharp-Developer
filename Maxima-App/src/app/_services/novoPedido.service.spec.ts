/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { NovoPedidoService } from './novoPedido.service';

describe('Service: NovoPedido', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [NovoPedidoService]
    });
  });

  it('should ...', inject([NovoPedidoService], (service: NovoPedidoService) => {
    expect(service).toBeTruthy();
  }));
});
