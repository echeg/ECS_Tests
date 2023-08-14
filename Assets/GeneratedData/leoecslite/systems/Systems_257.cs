using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System257 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component186> _p1;
EcsPool<Component319> _p2;
EcsPool<Component318> _p3;
EcsPool<Component126> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component186>().Inc<Component319>().Inc<Component318>().End();
   _p1 = _world.GetPool<Component186>();
   _p2 = _world.GetPool<Component319>();
   _p3 = _world.GetPool<Component318>();
   _pl0 = _world.GetPool<Component126>();
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
