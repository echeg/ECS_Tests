using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System6 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component117> _p1;
EcsPool<Component259> _p2;
EcsPool<Component27> _pl0;
EcsPool<Component36> _pl1;
EcsPool<Component248> _pl2;
EcsPool<Component38> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component117>().Inc<Component259>().End();
   _p1 = _world.GetPool<Component117>();
   _p2 = _world.GetPool<Component259>();
   _pl0 = _world.GetPool<Component27>();
   _pl1 = _world.GetPool<Component36>();
   _pl2 = _world.GetPool<Component248>();
   _pl3 = _world.GetPool<Component38>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl3.Has(entity))
   {
    q+=1;
    var component1 = _pl3.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
