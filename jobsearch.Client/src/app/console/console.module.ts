import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ConsoleRoutingModule } from './console-routing.module';
import { BsModule } from '../bs.module';


@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    BsModule,
    ConsoleRoutingModule,
  ]
})
export class ConsoleModule { }
