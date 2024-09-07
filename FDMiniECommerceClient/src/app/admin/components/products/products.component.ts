import { Component, OnInit } from '@angular/core';
import { BaseComponent, SpinnerType } from '../../../base/base.component';
import { NgxSpinnerService } from 'ngx-spinner';
import { HttpClientService } from '../../../services/common/http-client.service';
declare var $: any;

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss']
})
export class ProductsComponent extends BaseComponent implements OnInit {

  constructor(spinner:NgxSpinnerService,private httpClientService:HttpClientService) {
    super(spinner);
  }
    ngOnInit():void{
      this.showSpinner(SpinnerType.BallAtom);
      this.httpClientService.get({
        controller:"products"
      }).subscribe(data=>console.log(data));

      // this.httpClientService.post({
      //   controller:"products"
      // },{
      //   name:"Kalem",
      //   stock:100,
      //   price:15
      // }).subscribe();

      // this.httpClientService.put({
      //   controller:"products",
      // },{
      //   id:"a477c978-2e7f-431f-88da-3901dac8eac9",
      //   name:"A4 Kağıt",
      //   stock:1500,
      //   price:4.5
      // }).subscribe();

      // this.httpClientService.delete({
      //   controller:"products"
      // },"b7c7506b-deac-4d45-a46e-a1edbd78843c").subscribe();
    }
}
