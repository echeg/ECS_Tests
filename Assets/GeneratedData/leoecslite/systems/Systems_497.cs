using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System497 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component250> _p1;
EcsPool<Component472> _p2;
EcsPool<Component396> _p3;
EcsPool<Component400> _p4;
EcsPool<Component314> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component250>().Inc<Component472>().Inc<Component396>().Inc<Component400>().End();
   _p1 = _world.GetPool<Component250>();
   _p2 = _world.GetPool<Component472>();
   _p3 = _world.GetPool<Component396>();
   _p4 = _world.GetPool<Component400>();
   _pl0 = _world.GetPool<Component314>();
 }
 public void Run (IEcsSystems systems) {
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
  }
 }
}

}
