using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System427 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component493> _p1;
EcsPool<Component113> _p2;
EcsPool<Component427> _p3;
EcsPool<Component204> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component493>().Inc<Component113>().Inc<Component427>().End();
   _p1 = _world.GetPool<Component493>();
   _p2 = _world.GetPool<Component113>();
   _p3 = _world.GetPool<Component427>();
   _pl0 = _world.GetPool<Component204>();
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
