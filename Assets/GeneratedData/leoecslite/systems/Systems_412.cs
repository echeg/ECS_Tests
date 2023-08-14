using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System412 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component11> _p1;
EcsPool<Component480> _p2;
EcsPool<Component142> _p3;
EcsPool<Component202> _p4;
EcsPool<Component368> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component11>().Inc<Component480>().Inc<Component142>().Inc<Component202>().End();
   _p1 = _world.GetPool<Component11>();
   _p2 = _world.GetPool<Component480>();
   _p3 = _world.GetPool<Component142>();
   _p4 = _world.GetPool<Component202>();
   _pl0 = _world.GetPool<Component368>();
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
