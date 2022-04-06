import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { CollapseModule } from 'ngx-bootstrap/collapse';

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    CollapseModule,
  ],
  exports: [
    CollapseModule,
  ]
})
export class BsModule { }
