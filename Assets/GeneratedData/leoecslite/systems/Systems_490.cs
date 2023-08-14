using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System490 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component470> _p1;
EcsPool<Component74> _p2;
EcsPool<Component281> _p3;
EcsPool<Component349> _p4;
EcsPool<Component218> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component470>().Inc<Component74>().Inc<Component281>().Inc<Component349>().End();
   _p1 = _world.GetPool<Component470>();
   _p2 = _world.GetPool<Component74>();
   _p3 = _world.GetPool<Component281>();
   _p4 = _world.GetPool<Component349>();
   _pl0 = _world.GetPool<Component218>();
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
