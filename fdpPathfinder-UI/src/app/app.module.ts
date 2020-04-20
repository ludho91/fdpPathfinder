import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { CharacterComponent } from './character/character.component';
import { CharacterService } from './character.service';

@NgModule({
   declarations: [
      AppComponent,
      CharacterComponent
   ],
   imports: [
      BrowserModule,
      HttpClientModule
   ],
   providers: [CharacterService],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
