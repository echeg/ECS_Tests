using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System420 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component19> _p1;
EcsPool<Component360> _p2;
EcsPool<Component208> _p3;
EcsPool<Component384> _p4;
EcsPool<Component325> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component19>().Inc<Component360>().Inc<Component208>().Inc<Component384>().End();
   _p1 = _world.GetPool<Component19>();
   _p2 = _world.GetPool<Component360>();
   _p3 = _world.GetPool<Component208>();
   _p4 = _world.GetPool<Component384>();
   _pl0 = _world.GetPool<Component325>();
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
