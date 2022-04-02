using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System159 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component399> _p1;
EcsPool<Component312> _p2;
EcsPool<Component448> _p3;
EcsPool<Component189> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component399>().Inc<Component312>().Inc<Component448>().Inc<Component189>().End();
   _p1 = _world.GetPool<Component399>();
   _p2 = _world.GetPool<Component312>();
   _p3 = _world.GetPool<Component448>();
   _p4 = _world.GetPool<Component189>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
