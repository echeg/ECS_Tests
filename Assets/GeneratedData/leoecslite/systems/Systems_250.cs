using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System250 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component312> _p1;
EcsPool<Component236> _p2;
EcsPool<Component150> _p3;
EcsPool<Component122> _p4;
EcsPool<Component67> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component312>().Inc<Component236>().Inc<Component150>().Inc<Component122>().End();
   _p1 = _world.GetPool<Component312>();
   _p2 = _world.GetPool<Component236>();
   _p3 = _world.GetPool<Component150>();
   _p4 = _world.GetPool<Component122>();
   _pl0 = _world.GetPool<Component67>();
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
