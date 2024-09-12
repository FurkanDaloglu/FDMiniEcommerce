import { Directive, ElementRef, EventEmitter, HostListener, Input, Output, Renderer2, inject, input } from '@angular/core';
import { ProductService } from '../../services/common/models/product.service';
import { MatDialog } from '@angular/material/dialog';
import { DeleteDialogComponent, DeleteState } from '../../dialogs/delete-dialog/delete-dialog.component';
import { async } from 'rxjs';
import { HttpClientService } from '../../services/common/http-client.service';
import { AlertifyService, MessageType, Position } from '../../services/admin/alertify.service';
import { HttpErrorResponse } from '@angular/common/http';

declare var $: any;

@Directive({
  selector: '[appDelete]'
})
export class DeleteDirective {

  constructor(private element: ElementRef, private _renderer: Renderer2, private httpClientService: HttpClientService,
    private alertify: AlertifyService)
  {
    const img = this._renderer.createElement("img");
    img.setAttribute("src", "../../../../../assets/delete.png");
    img.setAttribute("style", "cursor: pointer;");
    img.width = 25;
    img.height = 25;
    _renderer.appendChild(element.nativeElement, img);
  }

  @Input() id: string;
  @Input() controller: string;
  @Output() callBack: EventEmitter<any> = new EventEmitter();

  @HostListener("click")
  async onClick() {
    this.openDialog(async () => {
      const td: HTMLTableCellElement = this.element.nativeElement;
      this.httpClientService.delete({
        controller: this.controller
      }, this.id).subscribe(data => {
        $(td.parentElement).fadeOut(2000, () => {
          this.callBack.emit();
          this.alertify.message("Ürün başarıyla silinmiştir.", {
            dismissOthers: true,
            messageType: MessageType.Success,
            position: Position.TopRight
          });
        });
      }, (errorResponse: HttpErrorResponse) => {
        this.alertify.message("Ürün silinirken bir hata oluştu.", {
          dismissOthers: true,
          messageType: MessageType.Error,
          position: Position.TopRight
        });
      });

    });

  }
  readonly dialog = inject(MatDialog)
  openDialog(afterClosed: any): void {
    const dialogRef = this.dialog.open(DeleteDialogComponent, {
      data: DeleteState.Yes,
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result == DeleteState.Yes)
        afterClosed();
    });
  }

}
