import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { LoginComponent } from './login/login.component';
import { HomeUsuarioComponent } from './home-usuario/home-usuario.component';
import { CadastroComponent } from './cadastro/cadastro.component';
import { RedefinirSenhaComponent } from './redefinir-senha/redefinir-senha.component';
import { CarteiraComponent } from './carteira/carteira.component';
import { AgmCoreModule } from '@agm/core';
import { CarbonoComponent } from './carbono/carbono.component';
import { BlogComponent } from './blog/blog.component';
import { CadastroPromocaoComponent } from './cadastro-promocao/cadastro-promocao.component';
@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    LoginComponent,
    HomeUsuarioComponent,
    CadastroComponent,
    RedefinirSenhaComponent,
    CarteiraComponent,
    CarbonoComponent,
    BlogComponent,
    CadastroPromocaoComponent,
    
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    AgmCoreModule.forRoot({
      apiKey: 'AIzaSyABybJZfNXwjLW10vkxSAdpmEEZHmxsaJ8'
    }), 
    RouterModule.forRoot([
      { path: '', component: LoginComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'home-usuario', component: HomeUsuarioComponent },
      { path: 'cadastro', component: CadastroComponent },
      { path: 'redefinirSenha', component: RedefinirSenhaComponent },
      { path: 'carteira', component: CarteiraComponent },
      { path: 'carbono', component: CarbonoComponent },
      { path: 'homeUsuario', component: HomeUsuarioComponent },
      { path: 'blog', component: BlogComponent },
      { path: 'casatroPromocao', component: CadastroPromocaoComponent } 
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
