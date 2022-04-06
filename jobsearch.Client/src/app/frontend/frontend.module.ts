import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { FrontendRoutingModule } from './frontend-routing.module';
import { BsModule } from '../bs.module';


@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    BsModule,
    FrontendRoutingModule
  ]
})
export class FrontendModule { }
