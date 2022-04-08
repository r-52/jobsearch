import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NavigationBarHeaderComponent } from './navigation-bar-header.component';

describe('NavigationBarHeaderComponent', () => {
  let component: NavigationBarHeaderComponent;
  let fixture: ComponentFixture<NavigationBarHeaderComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NavigationBarHeaderComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NavigationBarHeaderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
