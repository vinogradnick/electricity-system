import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ElectrictyObjectComponent } from './electricty-object.component';

describe('ElectrictyObjectComponent', () => {
  let component: ElectrictyObjectComponent;
  let fixture: ComponentFixture<ElectrictyObjectComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ElectrictyObjectComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ElectrictyObjectComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
