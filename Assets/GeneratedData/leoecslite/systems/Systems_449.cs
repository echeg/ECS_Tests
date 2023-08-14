using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System449 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component375> _p1;
EcsPool<Component66> _p2;
EcsPool<Component440> _p3;
EcsPool<Component397> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component375>().Inc<Component66>().Inc<Component440>().End();
   _p1 = _world.GetPool<Component375>();
   _p2 = _world.GetPool<Component66>();
   _p3 = _world.GetPool<Component440>();
   _pl0 = _world.GetPool<Component397>();
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
