using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System224 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component455> _p1;
EcsPool<Component465> _p2;
EcsPool<Component202> _p3;
EcsPool<Component259> _pl0;
EcsPool<Component244> _pl1;
EcsPool<Component292> _pl2;
EcsPool<Component92> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component455>().Inc<Component465>().Inc<Component202>().End();
   _p1 = _world.GetPool<Component455>();
   _p2 = _world.GetPool<Component465>();
   _p3 = _world.GetPool<Component202>();
   _pl0 = _world.GetPool<Component259>();
   _pl1 = _world.GetPool<Component244>();
   _pl2 = _world.GetPool<Component292>();
   _pl3 = _world.GetPool<Component92>();
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
