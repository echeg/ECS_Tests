using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System212 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component374> _p1;
EcsPool<Component349> _p2;
EcsPool<Component127> _p3;
EcsPool<Component480> _p4;
EcsPool<Component424> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component374>().Inc<Component349>().Inc<Component127>().Inc<Component480>().End();
   _p1 = _world.GetPool<Component374>();
   _p2 = _world.GetPool<Component349>();
   _p3 = _world.GetPool<Component127>();
   _p4 = _world.GetPool<Component480>();
   _pl0 = _world.GetPool<Component424>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   if (_p1.Has(entity))
   {
    _p1.Del(entity);
   }
   else
   {
    _p1.Add(entity);
   }
  }
 }
}

}
