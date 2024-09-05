import { Component } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';
import { BaseComponent, SpinnerType } from '../../../base/base.component';

@Component({
  selector: 'app-order',
  templateUrl: './order.component.html',
  styleUrl: './order.component.scss'
})
export class OrderComponent extends BaseComponent {

  constructor(spinner:NgxSpinnerService) {
    super(spinner);

    this.showSpinner(SpinnerType.BallAtom);
  }
}
