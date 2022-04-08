import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ConsoleRoutingModule } from './console-routing.module';
import { BsModule } from '../bs.module';
import { NavigationBarHeaderComponent } from './shared/components/header/navigation-bar-header/navigation-bar-header.component';


@NgModule({
  declarations: [
    NavigationBarHeaderComponent
  ],
  imports: [
    CommonModule,
    BsModule,
    ConsoleRoutingModule,
  ]
})
export class ConsoleModule { }
